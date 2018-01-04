using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xml_Parse_Islemi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_parseet_Click(object sender, EventArgs e)
        {
            ParseIslemi goster = new ParseIslemi();
            goster.Show();
            this.Hide();
        }


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(sonuc == DialogResult.No)
            {

            }
            if(sonuc==DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

            
        }

        private void btn_parseraporla_Click(object sender, EventArgs e)
        {
            ParseIslemi goster = new ParseIslemi();
            goster.Show();
            this.Hide();
        }

      
    }
}
