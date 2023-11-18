using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ListBox_ListView_RadioButton_CheckBox_MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb_sehir.SelectedIndex = 1;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Ogrenci og = new Ogrenci();
            og.Ad = txt_ad.Text;
            og.Soyad = txt_soyad.Text;
            og.Numara = (int)nmr_ogrenciNo.Value;
            og.Sehir = cmb_sehir.Text;
            og.TelefonNo = msk_telefon.Text;
            og.DogumTarihi = dateTimePicker1.Value;

            if (radioButton1.Checked)
                og.Cinsiyet = radioButton1.Text;
            else if (radioButton3.Checked)
                og.Cinsiyet = radioButton3.Text;
            else
                og.Cinsiyet = radioButton2.Text;

            //og.Cinsiyet = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;

            og.Dersler = "";
            if (chc_cSharp.Checked)
                og.Dersler += " " + chc_cSharp.Text;
            if (chc_aspNet.Checked)
                og.Dersler += " " + chc_aspNet.Text;
            if (chc_sql.Checked)
                og.Dersler += " " + chc_sql.Text;


            lstBox_ogrenciler.Items.Add(og.Ad + " " + og.Soyad + " " + og.Numara + " " + og.Cinsiyet + " " + og.DogumTarihi + " " + og.Dersler);

            ListViewItem lvi = new ListViewItem();
            lvi.Text = og.Ad;
            lvi.SubItems.Add(og.Soyad);
            lvi.SubItems.Add(og.Numara.ToString());
            lvi.SubItems.Add(og.TelefonNo);
            lvi.SubItems.Add(og.Sehir);
            lvi.SubItems.Add(og.DogumTarihi.ToString());
            lvi.SubItems.Add(og.Cinsiyet);
            lvi.SubItems.Add(og.Dersler);


            listView1.Items.Add(lvi);





            txt_ad.Text = "";
            txt_soyad.Clear();
            msk_telefon.Text = string.Empty;

            nmr_ogrenciNo.Value = nmr_ogrenciNo.Minimum;
            cmb_sehir.SelectedIndex = -1;
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            chc_aspNet.Checked = false;
            chc_cSharp.Checked = false;
            chc_sql.Checked = false;
        }
    }
}
