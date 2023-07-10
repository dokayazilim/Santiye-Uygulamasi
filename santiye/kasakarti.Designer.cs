namespace santiye
{
    partial class kasakarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasakarti));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dövizTÜrüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.kasano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kasaadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bakiye = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kasanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parabirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasakartiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebeDataSet40 = new santiye.onmuhasebeDataSet40();
            this.kasakartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebesmartDataSet1 = new santiye.onmuhasebesmartDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.toplamborc = new System.Windows.Forms.TextBox();
            this.parabirimi = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toplamalacak = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toplambakiye = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.kasakartiTableAdapter = new santiye.onmuhasebesmartDataSet1TableAdapters.kasakartiTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.kasakartiTableAdapter1 = new santiye.onmuhasebeDataSet40TableAdapters.kasakartiTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasakartiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebeDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasakartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.araçlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.dövizTÜrüToolStripMenuItem,
            this.aktarToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // dövizTÜrüToolStripMenuItem
            // 
            this.dövizTÜrüToolStripMenuItem.Name = "dövizTÜrüToolStripMenuItem";
            this.dövizTÜrüToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dövizTÜrüToolStripMenuItem.Text = "Döviz Kuru";
            this.dövizTÜrüToolStripMenuItem.Click += new System.EventHandler(this.dövizTÜrüToolStripMenuItem_Click);
            // 
            // aktarToolStripMenuItem
            // 
            this.aktarToolStripMenuItem.Name = "aktarToolStripMenuItem";
            this.aktarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aktarToolStripMenuItem.Text = "Aktar";
            this.aktarToolStripMenuItem.Click += new System.EventHandler(this.aktarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kasa No :";
            // 
            // kasano
            // 
            this.kasano.Location = new System.Drawing.Point(65, 34);
            this.kasano.Margin = new System.Windows.Forms.Padding(2);
            this.kasano.Name = "kasano";
            this.kasano.Size = new System.Drawing.Size(68, 20);
            this.kasano.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kasa Adı :";
            // 
            // kasaadi
            // 
            this.kasaadi.Location = new System.Drawing.Point(194, 34);
            this.kasaadi.Margin = new System.Windows.Forms.Padding(2);
            this.kasaadi.Name = "kasaadi";
            this.kasaadi.Size = new System.Drawing.Size(68, 20);
            this.kasaadi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bakiye :";
            // 
            // bakiye
            // 
            this.bakiye.Location = new System.Drawing.Point(313, 34);
            this.bakiye.Margin = new System.Windows.Forms.Padding(2);
            this.bakiye.Name = "bakiye";
            this.bakiye.Size = new System.Drawing.Size(68, 20);
            this.bakiye.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kasanoDataGridViewTextBoxColumn,
            this.kasaadiDataGridViewTextBoxColumn,
            this.bakiyeDataGridViewTextBoxColumn,
            this.parabirimiDataGridViewTextBoxColumn,
            this.borcDataGridViewTextBoxColumn,
            this.alacakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasakartiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(584, 135);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kasanoDataGridViewTextBoxColumn
            // 
            this.kasanoDataGridViewTextBoxColumn.DataPropertyName = "kasano";
            this.kasanoDataGridViewTextBoxColumn.HeaderText = "Kasa No";
            this.kasanoDataGridViewTextBoxColumn.Name = "kasanoDataGridViewTextBoxColumn";
            // 
            // kasaadiDataGridViewTextBoxColumn
            // 
            this.kasaadiDataGridViewTextBoxColumn.DataPropertyName = "kasaadi";
            this.kasaadiDataGridViewTextBoxColumn.HeaderText = "Kasa Adı";
            this.kasaadiDataGridViewTextBoxColumn.Name = "kasaadiDataGridViewTextBoxColumn";
            // 
            // bakiyeDataGridViewTextBoxColumn
            // 
            this.bakiyeDataGridViewTextBoxColumn.DataPropertyName = "bakiye";
            this.bakiyeDataGridViewTextBoxColumn.HeaderText = "Bakiye";
            this.bakiyeDataGridViewTextBoxColumn.Name = "bakiyeDataGridViewTextBoxColumn";
            // 
            // parabirimiDataGridViewTextBoxColumn
            // 
            this.parabirimiDataGridViewTextBoxColumn.DataPropertyName = "parabirimi";
            this.parabirimiDataGridViewTextBoxColumn.HeaderText = "Para Birimi";
            this.parabirimiDataGridViewTextBoxColumn.Name = "parabirimiDataGridViewTextBoxColumn";
            // 
            // borcDataGridViewTextBoxColumn
            // 
            this.borcDataGridViewTextBoxColumn.DataPropertyName = "borc";
            this.borcDataGridViewTextBoxColumn.HeaderText = "Borç";
            this.borcDataGridViewTextBoxColumn.Name = "borcDataGridViewTextBoxColumn";
            // 
            // alacakDataGridViewTextBoxColumn
            // 
            this.alacakDataGridViewTextBoxColumn.DataPropertyName = "alacak";
            this.alacakDataGridViewTextBoxColumn.HeaderText = "Alacak";
            this.alacakDataGridViewTextBoxColumn.Name = "alacakDataGridViewTextBoxColumn";
            // 
            // kasakartiBindingSource1
            // 
            this.kasakartiBindingSource1.DataMember = "kasakarti";
            this.kasakartiBindingSource1.DataSource = this.onmuhasebeDataSet40;
            // 
            // onmuhasebeDataSet40
            // 
            this.onmuhasebeDataSet40.DataSetName = "onmuhasebeDataSet40";
            this.onmuhasebeDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasakartiBindingSource
            // 
            this.kasakartiBindingSource.DataMember = "kasakarti";
            this.kasakartiBindingSource.DataSource = this.onmuhasebesmartDataSet1;
            // 
            // onmuhasebesmartDataSet1
            // 
            this.onmuhasebesmartDataSet1.DataSetName = "onmuhasebesmartDataSet1";
            this.onmuhasebesmartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Borç :";
            // 
            // toplamborc
            // 
            this.toplamborc.Location = new System.Drawing.Point(471, 207);
            this.toplamborc.Margin = new System.Windows.Forms.Padding(2);
            this.toplamborc.Name = "toplamborc";
            this.toplamborc.Size = new System.Drawing.Size(68, 20);
            this.toplamborc.TabIndex = 8;
            // 
            // parabirimi
            // 
            this.parabirimi.FormattingEnabled = true;
            this.parabirimi.Items.AddRange(new object[] {
            "TL",
            "$",
            "€"});
            this.parabirimi.Location = new System.Drawing.Point(383, 34);
            this.parabirimi.Margin = new System.Windows.Forms.Padding(2);
            this.parabirimi.Name = "parabirimi";
            this.parabirimi.Size = new System.Drawing.Size(82, 21);
            this.parabirimi.TabIndex = 4;
            this.parabirimi.Text = "TL";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(544, 207);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Toplam Alacak :";
            // 
            // toplamalacak
            // 
            this.toplamalacak.Location = new System.Drawing.Point(471, 227);
            this.toplamalacak.Margin = new System.Windows.Forms.Padding(2);
            this.toplamalacak.Name = "toplamalacak";
            this.toplamalacak.Size = new System.Drawing.Size(68, 20);
            this.toplamalacak.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(544, 227);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(49, 20);
            this.textBox7.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Toplam Bakiye :";
            // 
            // toplambakiye
            // 
            this.toplambakiye.Location = new System.Drawing.Point(471, 249);
            this.toplambakiye.Margin = new System.Windows.Forms.Padding(2);
            this.toplambakiye.Name = "toplambakiye";
            this.toplambakiye.Size = new System.Drawing.Size(68, 20);
            this.toplambakiye.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(544, 249);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(49, 20);
            this.textBox9.TabIndex = 13;
            // 
            // kasakartiTableAdapter
            // 
            this.kasakartiTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // kasakartiTableAdapter1
            // 
            this.kasakartiTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "Close.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(555, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 32);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kaydet.png");
            this.ımageList1.Images.SetKeyName(1, "gtk-refresh.png");
            this.ımageList1.Images.SetKeyName(2, "Close.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "gtk-refresh.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(512, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 32);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "kaydet.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(469, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kasakarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 283);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.toplambakiye);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.toplamalacak);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.parabirimi);
            this.Controls.Add(this.toplamborc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bakiye);
            this.Controls.Add(this.kasaadi);
            this.Controls.Add(this.kasano);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 321);
            this.Name = "kasakarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kasa Kartı";
            this.Load += new System.EventHandler(this.kasakarti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasakartiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebeDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasakartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dövizTÜrüToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kasano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kasaadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bakiye;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toplamborc;
        private System.Windows.Forms.ComboBox parabirimi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox toplamalacak;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox toplambakiye;
        private onmuhasebesmartDataSet1 onmuhasebesmartDataSet1;
        private System.Windows.Forms.BindingSource kasakartiBindingSource;
        private onmuhasebesmartDataSet1TableAdapters.kasakartiTableAdapter kasakartiTableAdapter;
        public System.Windows.Forms.Label label7;
        private onmuhasebeDataSet40 onmuhasebeDataSet40;
        private System.Windows.Forms.BindingSource kasakartiBindingSource1;
        private onmuhasebeDataSet40TableAdapters.kasakartiTableAdapter kasakartiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parabirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alacakDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem aktarToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}