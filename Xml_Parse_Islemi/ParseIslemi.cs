using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data.SqlClient;


namespace Xml_Parse_Islemi
{
    public partial class ParseIslemi : Form
    {
        string MsgId = "";
        List<string> listData = new List<string>();
        public ParseIslemi()
        {
            InitializeComponent();
        }

        private void btn_raporla_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1;

            for (int j = 0; j < dgv_parseedilenigetir.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dgv_parseedilenigetir.Columns[j].HeaderText;

            }

            StartRow++;

            for (int i = 0; i < dgv_parseedilenigetir.Rows.Count; i++)
            {

                for (int j = 0; j < dgv_parseedilenigetir.Columns.Count; j++)
                {

                    try
                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];

                        myRange.Value2 = dgv_parseedilenigetir[j, i].Value == null ? "" : dgv_parseedilenigetir[j, i].Value;

                    }

                    catch
                    {
                        ;
                    }

                }

            }
        }

        private void btn_menuyedon_Click(object sender, EventArgs e)
        {
            Menu goster = new Menu();
            goster.Show();
            this.Hide();
        }

        private void btn_gozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Xml Dosyası | *.xml";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Xml Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {

                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;

                txt_sayfaninyeri.Text += DosyaYolu + "\r\n";

            }


        }




        private void btn_parseet_Click(object sender, EventArgs e)
        {

            Xml_DataOku();

        }


        public void Xml_DataOku()
        {
            List<CdtTrfTxInf_Data> listData = new List<CdtTrfTxInf_Data>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(txt_sayfaninyeri.Text.Trim());
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/CstmrCdtTrfInitn");
            string  CreDtTm = "", NbOfTxs = "", CtrlSum = "", Nm = "";
            string PmtInfId = "", PmtMtd = "", BtchBookg = "", ReqdExctnDt = "", Ctry = "", AdrLine = "", IBAN = "", BIC = "", ChrgBr = "";
            foreach (XmlNode node in nodeList)
            {
                MsgId = node.SelectSingleNode("GrpHdr").SelectSingleNode("MsgId").InnerText;
                CreDtTm = node.SelectSingleNode("GrpHdr").SelectSingleNode("CreDtTm").InnerText;
                NbOfTxs = node.SelectSingleNode("GrpHdr").SelectSingleNode("NbOfTxs").InnerText;
                CtrlSum = node.SelectSingleNode("GrpHdr").SelectSingleNode("CtrlSum").InnerText;
                Nm = node.SelectSingleNode("GrpHdr").SelectSingleNode("InitgPty").SelectSingleNode("Nm").InnerText;
                PmtInfId = node.SelectSingleNode("PmtInf").SelectSingleNode("PmtInfId").InnerText;
                PmtMtd = node.SelectSingleNode("PmtInf").SelectSingleNode("PmtMtd").InnerText;
                BtchBookg = node.SelectSingleNode("PmtInf").SelectSingleNode("BtchBookg").InnerText;
                NbOfTxs = node.SelectSingleNode("PmtInf").SelectSingleNode("NbOfTxs").InnerText;
                CtrlSum = node.SelectSingleNode("PmtInf").SelectSingleNode("CtrlSum").InnerText;
                ReqdExctnDt = node.SelectSingleNode("PmtInf").SelectSingleNode("ReqdExctnDt").InnerText;
                Nm = node.SelectSingleNode("PmtInf").SelectSingleNode("Dbtr").SelectSingleNode("Nm").InnerText;
                Ctry = node.SelectSingleNode("PmtInf").SelectSingleNode("Dbtr").SelectSingleNode("PstlAdr").SelectSingleNode("Ctry").InnerText;
                AdrLine = node.SelectSingleNode("PmtInf").SelectSingleNode("Dbtr").SelectSingleNode("PstlAdr").SelectSingleNode("AdrLine").InnerText;
                IBAN = node.SelectSingleNode("PmtInf").SelectSingleNode("DbtrAcct").SelectSingleNode("Id").SelectSingleNode("IBAN").InnerText;
                BIC = node.SelectSingleNode("PmtInf").SelectSingleNode("DbtrAgt").SelectSingleNode("FinInstnId").SelectSingleNode("BIC").InnerText;
                ChrgBr = node.SelectSingleNode("PmtInf").SelectSingleNode("ChrgBr").InnerText;
                XmlNodeList nodeList2 = xmlDoc.DocumentElement.SelectNodes("/CstmrCdtTrfInitn/PmtInf/CdtTrfTxInf");
                foreach (XmlNode node2 in nodeList2)
                {
                    CdtTrfTxInf_Data CD = new CdtTrfTxInf_Data();
                    CD.PmtId_InstrId = node2.SelectSingleNode("PmtId").SelectSingleNode("InstrId").InnerText;
                    CD.PmtId_EndToEndId = node2.SelectSingleNode("PmtId").SelectSingleNode("EndToEndId").InnerText;
                    CD.Amt_InstdAmt = node2.SelectSingleNode("Amt").SelectSingleNode("InstdAmt").InnerText;
                    CD.CdtrAgt_FinInstnId_BIC = node2.SelectSingleNode("CdtrAgt").SelectSingleNode("FinInstnId").SelectSingleNode("BIC").InnerText;
                    CD.Cdtr_Nm = node2.SelectSingleNode("Cdtr").SelectSingleNode("Nm").InnerText;
                    CD.Cdtr_PstlAdr_Ctry = node2.SelectSingleNode("Cdtr").SelectSingleNode("PstlAdr").SelectSingleNode("Ctry").InnerText;
                    CD.Cdtr_PstlAdr_AdrLine = node2.SelectSingleNode("Cdtr").SelectSingleNode("PstlAdr").SelectSingleNode("AdrLine").InnerText;
                    CD.CdtrAcct_Id_IBAN = node2.SelectSingleNode("CdtrAcct").SelectSingleNode("Id").SelectSingleNode("IBAN").InnerText;
                    CD.RmtInf_Ustrd = node2.SelectSingleNode("RmtInf").SelectSingleNode("Ustrd").InnerText;
                    listData.Add(CD);
                }

            }


            //SqlConnection sqlConInsert = new SqlConnection();
            //SqlTransaction myTransaction = null;

            //// XML 'den okuduğumuz datayı db' ye kaydediyoruz
            //try
            //{

            //    sqlConInsert.ConnectionString = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=XMLPARSE;Integrated Security=True";
            //    SqlCommand cmnd = new SqlCommand();
            //    SqlCommand cmnd2 = new SqlCommand();
            //    cmnd.Connection = sqlConInsert;
            //    cmnd2.Connection = sqlConInsert;

            //    sqlConInsert.Open();
            //    myTransaction = sqlConInsert.BeginTransaction();
            //    cmnd.Transaction = myTransaction;
            //    cmnd2.Transaction = myTransaction;

            //    cmnd.CommandText = "INSERT INTO TagData (MessageId,CreditDateTime,NumberOfTaxes,ControlSummary,PaymentInfoId ,PaymentMethod ,BatchBooking ,RequiredExecutionDate ,Name,Country ,AddressLine ,IBAN ,BIC,ChrgBr) " +
            //                       "VALUES (@MessageId,@CreditDateTime, @NumberOfTaxes,@ControlSummary,@PaymentInfoId,@PaymentMethod,@BatchBooking,@RequiredExecutionDate,@Name,@Country,@AddressLine,@IBAN,@BIC,@ChrgBr) ";



            //    cmnd.Parameters.AddWithValue("@MessageId", MsgId);
            //    cmnd.Parameters.AddWithValue("@CreditDateTime",CreDtTm);
            //    cmnd.Parameters.AddWithValue("@NumberOfTaxes", NbOfTxs);
            //    cmnd.Parameters.AddWithValue("@ControlSummary", CtrlSum);
            //    cmnd.Parameters.AddWithValue("@PaymentInfoId", PmtInfId);
            //    cmnd.Parameters.AddWithValue("@PaymentMethod", PmtMtd);
            //    cmnd.Parameters.AddWithValue("@BatchBooking", BtchBookg);
            //    cmnd.Parameters.AddWithValue("@RequiredExecutionDate", ReqdExctnDt);
            //    cmnd.Parameters.AddWithValue("@Name", Nm);
            //    cmnd.Parameters.AddWithValue("@Country", Ctry);
            //    cmnd.Parameters.AddWithValue("@AddressLine", AdrLine);
            //    cmnd.Parameters.AddWithValue("@IBAN", IBAN);
            //    cmnd.Parameters.AddWithValue("@BIC", BIC);
            //    cmnd.Parameters.AddWithValue("@ChrgBr", ChrgBr);

            //    //try
            //    // {


            //    cmnd.ExecuteNonQuery();
            //    cmnd.Parameters.Clear();
            //    for (int i = 0; i < listData.Count; i++)
            //    {
            //        cmnd2.CommandText = "INSERT INTO CreditTransferTextInfo(MessageId,InstrumentId,EndToEndId,InstrumentAmount,BIC,Name,Country,AddressLine,IBAN,Ustrd) " +
            //                           "VALUES (@Msg_Id,@InstrumentId,@EndToEndId, @InstrumentAmount,@BIC,@Name,@Country,@AddressLine,@IBAN,@Ustrd) ";


            //        cmnd2.Parameters.AddWithValue("@Msg_Id", MsgId);
            //        cmnd2.Parameters.AddWithValue("@InstrumentId", listData[i].PmtId_InstrId);
            //        cmnd2.Parameters.AddWithValue("@EndToEndId", listData[i].PmtId_EndToEndId);
            //        cmnd2.Parameters.AddWithValue("@InstrumentAmount", listData[i].Amt_InstdAmt);
            //        cmnd2.Parameters.AddWithValue("@BIC", listData[i].CdtrAgt_FinInstnId_BIC);
            //        cmnd2.Parameters.AddWithValue("@Name", listData[i].Cdtr_Nm);
            //        cmnd2.Parameters.AddWithValue("@Country", listData[i].Cdtr_PstlAdr_Ctry);
            //        cmnd2.Parameters.AddWithValue("@AddressLine", listData[i].Cdtr_PstlAdr_AdrLine);
            //        cmnd2.Parameters.AddWithValue("@IBAN", listData[i].CdtrAcct_Id_IBAN);
            //        cmnd2.Parameters.AddWithValue("@Ustrd", listData[i].RmtInf_Ustrd);
            //        cmnd2.ExecuteNonQuery();
            //        cmnd2.Parameters.Clear();
            //    }





            //}
            //catch (Exception ex)
            //{
            //    myTransaction.Rollback();
            //    MessageBox.Show("Xml datası güncellenirken hata oluştu!");
            //}
            //finally
            //{
            //    myTransaction.Commit();
            //    sqlConInsert.Close();
            //}

            SqlConnection sqlConSelect = new SqlConnection();
            sqlConSelect.ConnectionString = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=XMLPARSE;Integrated Security=True";
            sqlConSelect.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = sqlConSelect;
            cmdSelect.CommandText = @"select * from TagData T with(nolock)
                                      where T.MessageId=" + MsgId + "";
            //            cmdSelect.CommandText = @"select * from TagData T with(nolock)
            //                                      inner join CreditTransferTextInfo C with(nolock) on  T.MessageId=C.MessageId
            //                                      where T.MessageId="+MsgId+"";
            SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_parseedilenigetir.DataSource = dt;
            sqlConSelect.Close();


        }



        private void dgv_parseedilenigetir_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_parseedilenigetir.SelectedRows)
            {
                string MsgID = row.Cells[0].Value.ToString();
                Xml_Detay form2 = new Xml_Detay(MsgId);
                form2.ShowDialog();
                
            }
        }
    }

     
  
}
