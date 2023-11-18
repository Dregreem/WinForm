namespace _02_ListBox_ListView_RadioButton_CheckBox_MaskedTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstBox_ogrenciler = new System.Windows.Forms.ListBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.nmr_ogrenciNo = new System.Windows.Forms.NumericUpDown();
            this.chc_aspNet = new System.Windows.Forms.CheckBox();
            this.chc_sql = new System.Windows.Forms.CheckBox();
            this.chc_cSharp = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.msk_telefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_ogrenciNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.lstBox_ogrenciler);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.nmr_ogrenciNo);
            this.groupBox1.Controls.Add(this.chc_aspNet);
            this.groupBox1.Controls.Add(this.chc_sql);
            this.groupBox1.Controls.Add(this.chc_cSharp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_sehir);
            this.groupBox1.Controls.Add(this.msk_telefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(63, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1520, 681);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ KAYIT";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(389, 407);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 29);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Belirtme";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(556, 260);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(916, 190);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Numara";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Şehir";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doğum Tarihi";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cinsiyet";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dersler";
            // 
            // lstBox_ogrenciler
            // 
            this.lstBox_ogrenciler.FormattingEnabled = true;
            this.lstBox_ogrenciler.ItemHeight = 25;
            this.lstBox_ogrenciler.Location = new System.Drawing.Point(556, 57);
            this.lstBox_ogrenciler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBox_ogrenciler.Name = "lstBox_ogrenciler";
            this.lstBox_ogrenciler.Size = new System.Drawing.Size(916, 129);
            this.lstBox_ogrenciler.TabIndex = 21;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(44, 527);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(421, 42);
            this.btn_kaydet.TabIndex = 20;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // nmr_ogrenciNo
            // 
            this.nmr_ogrenciNo.Location = new System.Drawing.Point(192, 167);
            this.nmr_ogrenciNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmr_ogrenciNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_ogrenciNo.Name = "nmr_ogrenciNo";
            this.nmr_ogrenciNo.Size = new System.Drawing.Size(275, 30);
            this.nmr_ogrenciNo.TabIndex = 19;
            this.nmr_ogrenciNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chc_aspNet
            // 
            this.chc_aspNet.AutoSize = true;
            this.chc_aspNet.Location = new System.Drawing.Point(351, 464);
            this.chc_aspNet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_aspNet.Name = "chc_aspNet";
            this.chc_aspNet.Size = new System.Drawing.Size(120, 29);
            this.chc_aspNet.TabIndex = 18;
            this.chc_aspNet.Text = "ASP.NET";
            this.chc_aspNet.UseVisualStyleBackColor = true;
            // 
            // chc_sql
            // 
            this.chc_sql.AutoSize = true;
            this.chc_sql.Location = new System.Drawing.Point(263, 464);
            this.chc_sql.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_sql.Name = "chc_sql";
            this.chc_sql.Size = new System.Drawing.Size(75, 29);
            this.chc_sql.TabIndex = 17;
            this.chc_sql.Text = "SQL";
            this.chc_sql.UseVisualStyleBackColor = true;
            // 
            // chc_cSharp
            // 
            this.chc_cSharp.AutoSize = true;
            this.chc_cSharp.Location = new System.Drawing.Point(191, 464);
            this.chc_cSharp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chc_cSharp.Name = "chc_cSharp";
            this.chc_cSharp.Size = new System.Drawing.Size(60, 29);
            this.chc_cSharp.TabIndex = 16;
            this.chc_cSharp.Text = "C#";
            this.chc_cSharp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dersler:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(289, 407);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 29);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(191, 407);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 29);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Erkek";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cinsiyet:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 347);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 30);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şehir:";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Hatay",
            "İstanbul",
            "İzmir",
            "KahramanMaraş",
            "Kars",
            "Kırklareli",
            "Malatya",
            "Mersin",
            "Edirne",
            "Tekirdağ",
            "Çanakkale",
            "İzmit",
            "Kocaeli",
            "Sakarya",
            "Rize",
            "Trabzon",
            "Erzurum",
            "Kars",
            "Düzce",
            "Osmaniye",
            "Niğde",
            "Samsun"});
            this.cmb_sehir.Location = new System.Drawing.Point(191, 286);
            this.cmb_sehir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(273, 33);
            this.cmb_sehir.TabIndex = 8;
            // 
            // msk_telefon
            // 
            this.msk_telefon.Location = new System.Drawing.Point(191, 228);
            this.msk_telefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msk_telefon.Mask = "aaa-aaa-aa-aa";
            this.msk_telefon.Name = "msk_telefon";
            this.msk_telefon.Size = new System.Drawing.Size(273, 30);
            this.msk_telefon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci No:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(191, 112);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(273, 30);
            this.txt_soyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadınız:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(191, 57);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(273, 30);
            this.txt_ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 622);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_ogrenciNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListBox lstBox_ogrenciler;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.NumericUpDown nmr_ogrenciNo;
        private System.Windows.Forms.CheckBox chc_aspNet;
        private System.Windows.Forms.CheckBox chc_sql;
        private System.Windows.Forms.CheckBox chc_cSharp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.MaskedTextBox msk_telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

