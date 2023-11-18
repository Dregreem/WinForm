using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TextBox_Label_Button_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_username.Text;
            string sifre = txt_password.Text;

            if(kullaniciAdi=="sexi_velet" && sifre == "123")
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
