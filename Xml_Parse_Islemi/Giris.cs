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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }

        private void LogiKontrol()
        {
            int count = 0;
            string connectionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connectionString = "Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=XMLPARSE;Integrated Security=True";
            sql = " select KullaniciAdi, Sifre, 1 as AdminMi from Yonetici " ;
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string KullaniciAdi = dataReader["KullaniciAdi"].ToString();
                    string Sifre = dataReader["Sifre"].ToString();
                    int admin = Convert.ToInt32(dataReader["AdminMi"]);

                    if (KullaniciAdi == txt_kadı.Text.Trim())
                    {
                        count++;
                        if (Sifre == txt_sifre.Text.Trim())
                        {
                            
                                Menu goster = new Menu();
                                goster.Show();
                                this.Hide();
                        }
                    
                        else
                            MessageBox.Show("Hatalı şifre, tekrar deneyiniz ! ");
                    }

                }
                dataReader.Close();
                command.Dispose();
                connection.Close();

                if (count == 0)
                    MessageBox.Show("Kullanıcı bilgilerinizi kontrol edip tekrar deneyiniz ! ");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            LogiKontrol();
        }

       

     
        

    }
}
