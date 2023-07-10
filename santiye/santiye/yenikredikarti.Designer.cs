namespace santiye
{
    partial class yenikredikarti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yenikredikarti));
            this.hesapno = new System.Windows.Forms.TextBox();
            this.islemtarihi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cariadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guvenlikkodudiger = new System.Windows.Forms.TextBox();
            this.guvenlikkodu = new System.Windows.Forms.TextBox();
            this.kullanimtarihidiger = new System.Windows.Forms.ComboBox();
            this.kullanimtarihi = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.parabirimi = new System.Windows.Forms.ComboBox();
            this.dekontno = new System.Windows.Forms.TextBox();
            this.subeadi = new System.Windows.Forms.TextBox();
            this.bankaadi = new System.Windows.Forms.TextBox();
            this.bakiye = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yedekALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hesapno
            // 
            this.hesapno.Location = new System.Drawing.Point(362, 28);
            this.hesapno.Name = "hesapno";
            this.hesapno.Size = new System.Drawing.Size(161, 20);
            this.hesapno.TabIndex = 6;
            // 
            // islemtarihi
            // 
            this.islemtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.islemtarihi.Location = new System.Drawing.Point(93, 49);
            this.islemtarihi.Name = "islemtarihi";
            this.islemtarihi.Size = new System.Drawing.Size(161, 20);
            this.islemtarihi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(228, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cariadi
            // 
            this.cariadi.Location = new System.Drawing.Point(93, 25);
            this.cariadi.Name = "cariadi";
            this.cariadi.Size = new System.Drawing.Size(161, 20);
            this.cariadi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "IBAN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bakiye :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hesap No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şube Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Banka Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guvenlikkodudiger);
            this.groupBox1.Controls.Add(this.guvenlikkodu);
            this.groupBox1.Controls.Add(this.kullanimtarihidiger);
            this.groupBox1.Controls.Add(this.kullanimtarihi);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.aciklama);
            this.groupBox1.Controls.Add(this.parabirimi);
            this.groupBox1.Controls.Add(this.dekontno);
            this.groupBox1.Controls.Add(this.subeadi);
            this.groupBox1.Controls.Add(this.bankaadi);
            this.groupBox1.Controls.Add(this.bakiye);
            this.groupBox1.Controls.Add(this.hesapno);
            this.groupBox1.Controls.Add(this.islemtarihi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cariadi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 156);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // guvenlikkodudiger
            // 
            this.guvenlikkodudiger.Location = new System.Drawing.Point(435, 121);
            this.guvenlikkodudiger.Margin = new System.Windows.Forms.Padding(2);
            this.guvenlikkodudiger.Name = "guvenlikkodudiger";
            this.guvenlikkodudiger.Size = new System.Drawing.Size(86, 20);
            this.guvenlikkodudiger.TabIndex = 13;
            // 
            // guvenlikkodu
            // 
            this.guvenlikkodu.Location = new System.Drawing.Point(362, 121);
            this.guvenlikkodu.Margin = new System.Windows.Forms.Padding(2);
            this.guvenlikkodu.Name = "guvenlikkodu";
            this.guvenlikkodu.Size = new System.Drawing.Size(71, 20);
            this.guvenlikkodu.TabIndex = 12;
            // 
            // kullanimtarihidiger
            // 
            this.kullanimtarihidiger.FormattingEnabled = true;
            this.kullanimtarihidiger.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.kullanimtarihidiger.Location = new System.Drawing.Point(435, 95);
            this.kullanimtarihidiger.Margin = new System.Windows.Forms.Padding(2);
            this.kullanimtarihidiger.Name = "kullanimtarihidiger";
            this.kullanimtarihidiger.Size = new System.Drawing.Size(86, 21);
            this.kullanimtarihidiger.TabIndex = 11;
            // 
            // kullanimtarihi
            // 
            this.kullanimtarihi.FormattingEnabled = true;
            this.kullanimtarihi.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.kullanimtarihi.Location = new System.Drawing.Point(362, 95);
            this.kullanimtarihi.Margin = new System.Windows.Forms.Padding(2);
            this.kullanimtarihi.Name = "kullanimtarihi";
            this.kullanimtarihi.Size = new System.Drawing.Size(71, 21);
            this.kullanimtarihi.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(228, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 21);
            this.button5.TabIndex = 16;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(93, 120);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(161, 20);
            this.aciklama.TabIndex = 5;
            // 
            // parabirimi
            // 
            this.parabirimi.FormattingEnabled = true;
            this.parabirimi.Items.AddRange(new object[] {
            "TL",
            "DOLAR($)",
            "EURO(€)"});
            this.parabirimi.Location = new System.Drawing.Point(455, 51);
            this.parabirimi.Name = "parabirimi";
            this.parabirimi.Size = new System.Drawing.Size(67, 21);
            this.parabirimi.TabIndex = 8;
            this.parabirimi.Text = "TL";
            // 
            // dekontno
            // 
            this.dekontno.Location = new System.Drawing.Point(362, 73);
            this.dekontno.Name = "dekontno";
            this.dekontno.Size = new System.Drawing.Size(160, 20);
            this.dekontno.TabIndex = 9;
            // 
            // subeadi
            // 
            this.subeadi.Location = new System.Drawing.Point(93, 95);
            this.subeadi.Name = "subeadi";
            this.subeadi.Size = new System.Drawing.Size(161, 20);
            this.subeadi.TabIndex = 4;
            // 
            // bankaadi
            // 
            this.bankaadi.Location = new System.Drawing.Point(93, 73);
            this.bankaadi.Name = "bankaadi";
            this.bankaadi.Size = new System.Drawing.Size(161, 20);
            this.bankaadi.TabIndex = 3;
            // 
            // bakiye
            // 
            this.bakiye.Location = new System.Drawing.Point(362, 51);
            this.bakiye.Name = "bakiye";
            this.bakiye.Size = new System.Drawing.Size(88, 20);
            this.bakiye.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Güvenlik Kodu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kullanım Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "İşlem Tarihi :";
            // 
            // yedekALToolStripMenuItem
            // 
            this.yedekALToolStripMenuItem.Name = "yedekALToolStripMenuItem";
            this.yedekALToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.yedekALToolStripMenuItem.Text = "Aktar";
            this.yedekALToolStripMenuItem.Click += new System.EventHandler(this.yedekALToolStripMenuItem_Click);
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.yedekALToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.araçlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "refresh.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(236, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 45);
            this.button3.TabIndex = 15;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Close.png");
            this.ımageList1.Images.SetKeyName(1, "kaydet.png");
            this.ımageList1.Images.SetKeyName(2, "refresh.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "kaydet.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(43, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "Close.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(417, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 45);
            this.button4.TabIndex = 16;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // yenikredikarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 282);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(577, 282);
            this.Name = "yenikredikarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kredi Kartı Hesabı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox hesapno;
        public System.Windows.Forms.DateTimePicker islemtarihi;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox cariadi;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox aciklama;
        public System.Windows.Forms.ComboBox parabirimi;
        public System.Windows.Forms.TextBox dekontno;
        public System.Windows.Forms.TextBox subeadi;
        public System.Windows.Forms.TextBox bankaadi;
        public System.Windows.Forms.TextBox bakiye;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ToolStripMenuItem yedekALToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox kullanimtarihi;
        private System.Windows.Forms.ComboBox kullanimtarihidiger;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox guvenlikkodudiger;
        private System.Windows.Forms.TextBox guvenlikkodu;
    }
}