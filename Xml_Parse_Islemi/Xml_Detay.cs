using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Xml_Parse_Islemi
{
    public partial class Xml_Detay : Form
    {
        string msgID = "";
        public Xml_Detay(string Msg)
        {
            InitializeComponent();
            msgID = Msg;
        }



        private void Xml_Detay_Load(object sender, EventArgs e)
        {
            DetayGetir();
        }

        public void DetayGetir ()
        {
            SqlConnection sqlConSelect = new SqlConnection();
            sqlConSelect.ConnectionString = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=XMLPARSE;Integrated Security=True";
            sqlConSelect.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = sqlConSelect;
            cmdSelect.CommandText = @"select * from CreditTransferTextInfo  with(nolock)
                                      where MessageId=" + msgID + "";

            SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_XmlDetay.DataSource = dt;
            sqlConSelect.Close();
        }

        private void btn_raporla2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1;

            for (int j = 0; j < dgv_XmlDetay.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dgv_XmlDetay.Columns[j].HeaderText;

            }

            StartRow++;

            for (int i = 0; i < dgv_XmlDetay.Rows.Count; i++)
            {

                for (int j = 0; j < dgv_XmlDetay.Columns.Count; j++)
                {

                    try
                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];

                        myRange.Value2 = dgv_XmlDetay[j, i].Value == null ? "" : dgv_XmlDetay[j, i].Value;

                    }

                    catch
                    {
                        ;
                    }

                }

            }
        }

     


    }
}
