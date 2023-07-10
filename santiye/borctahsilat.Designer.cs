namespace santiye
{
    partial class borctahsilat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borctahsilat));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.parabirimi = new System.Windows.Forms.ComboBox();
            this.islemturu = new System.Windows.Forms.ComboBox();
            this.islemtarihi = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.evrakno = new System.Windows.Forms.TextBox();
            this.bakiye = new System.Windows.Forms.TextBox();
            this.tutar = new System.Windows.Forms.TextBox();
            this.cariadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cariadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evraknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parabirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahsilatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebeDataSet23 = new santiye.onmuhasebeDataSet23();
            this.tahsilatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebesmartDataSet24 = new santiye.onmuhasebesmartDataSet24();
            this.tahsilatTableAdapter = new santiye.onmuhasebesmartDataSet24TableAdapters.tahsilatTableAdapter();
            this.tahsilatTableAdapter1 = new santiye.onmuhasebeDataSet23TableAdapters.tahsilatTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebeDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartDataSet24)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
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
            // aktarToolStripMenuItem
            // 
            this.aktarToolStripMenuItem.Name = "aktarToolStripMenuItem";
            this.aktarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aktarToolStripMenuItem.Text = "Aktar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.parabirimi);
            this.groupBox1.Controls.Add(this.islemturu);
            this.groupBox1.Controls.Add(this.islemtarihi);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.aciklama);
            this.groupBox1.Controls.Add(this.evrakno);
            this.groupBox1.Controls.Add(this.bakiye);
            this.groupBox1.Controls.Add(this.tutar);
            this.groupBox1.Controls.Add(this.cariadi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(485, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tahsil Edilecek";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(119, 58);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 21);
            this.button5.TabIndex = 13;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // parabirimi
            // 
            this.parabirimi.FormattingEnabled = true;
            this.parabirimi.Items.AddRange(new object[] {
            "TL",
            "$",
            "€"});
            this.parabirimi.Location = new System.Drawing.Point(309, 38);
            this.parabirimi.Margin = new System.Windows.Forms.Padding(2);
            this.parabirimi.Name = "parabirimi";
            this.parabirimi.Size = new System.Drawing.Size(78, 21);
            this.parabirimi.TabIndex = 12;
            // 
            // islemturu
            // 
            this.islemturu.FormattingEnabled = true;
            this.islemturu.Items.AddRange(new object[] {
            "Borç",
            "Alacak"});
            this.islemturu.Location = new System.Drawing.Point(309, 81);
            this.islemturu.Margin = new System.Windows.Forms.Padding(2);
            this.islemturu.Name = "islemturu";
            this.islemturu.Size = new System.Drawing.Size(78, 21);
            this.islemturu.TabIndex = 11;
            // 
            // islemtarihi
            // 
            this.islemtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.islemtarihi.Location = new System.Drawing.Point(75, 81);
            this.islemtarihi.Margin = new System.Windows.Forms.Padding(2);
            this.islemtarihi.Name = "islemtarihi";
            this.islemtarihi.Size = new System.Drawing.Size(79, 20);
            this.islemtarihi.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(120, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 21);
            this.button4.TabIndex = 9;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(407, 77);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(407, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(407, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(309, 60);
            this.aciklama.Margin = new System.Windows.Forms.Padding(2);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(78, 20);
            this.aciklama.TabIndex = 5;
            // 
            // evrakno
            // 
            this.evrakno.Location = new System.Drawing.Point(75, 59);
            this.evrakno.Margin = new System.Windows.Forms.Padding(2);
            this.evrakno.Name = "evrakno";
            this.evrakno.Size = new System.Drawing.Size(78, 20);
            this.evrakno.TabIndex = 3;
            // 
            // bakiye
            // 
            this.bakiye.Location = new System.Drawing.Point(75, 39);
            this.bakiye.Margin = new System.Windows.Forms.Padding(2);
            this.bakiye.Name = "bakiye";
            this.bakiye.Size = new System.Drawing.Size(78, 20);
            this.bakiye.TabIndex = 2;
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(309, 19);
            this.tutar.Margin = new System.Windows.Forms.Padding(2);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(78, 20);
            this.tutar.TabIndex = 1;
            // 
            // cariadi
            // 
            this.cariadi.Location = new System.Drawing.Point(76, 19);
            this.cariadi.Margin = new System.Windows.Forms.Padding(2);
            this.cariadi.Name = "cariadi";
            this.cariadi.Size = new System.Drawing.Size(78, 20);
            this.cariadi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "İşlem Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bakiye :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "İşlem Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Açıklama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kasa Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tahsil Edilecek Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Para Birimi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cariadiDataGridViewTextBoxColumn,
            this.bakiyeDataGridViewTextBoxColumn,
            this.evraknoDataGridViewTextBoxColumn,
            this.islemtarihiDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.parabirimiDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.islemturuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tahsilatBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(485, 114);
            this.dataGridView1.TabIndex = 2;
            // 
            // cariadiDataGridViewTextBoxColumn
            // 
            this.cariadiDataGridViewTextBoxColumn.DataPropertyName = "cariadi";
            this.cariadiDataGridViewTextBoxColumn.HeaderText = "Cari Adı";
            this.cariadiDataGridViewTextBoxColumn.Name = "cariadiDataGridViewTextBoxColumn";
            // 
            // bakiyeDataGridViewTextBoxColumn
            // 
            this.bakiyeDataGridViewTextBoxColumn.DataPropertyName = "bakiye";
            this.bakiyeDataGridViewTextBoxColumn.HeaderText = "Bakiye";
            this.bakiyeDataGridViewTextBoxColumn.Name = "bakiyeDataGridViewTextBoxColumn";
            // 
            // evraknoDataGridViewTextBoxColumn
            // 
            this.evraknoDataGridViewTextBoxColumn.DataPropertyName = "evrakno";
            this.evraknoDataGridViewTextBoxColumn.HeaderText = "Evrak No";
            this.evraknoDataGridViewTextBoxColumn.Name = "evraknoDataGridViewTextBoxColumn";
            // 
            // islemtarihiDataGridViewTextBoxColumn
            // 
            this.islemtarihiDataGridViewTextBoxColumn.DataPropertyName = "islemtarihi";
            this.islemtarihiDataGridViewTextBoxColumn.HeaderText = "İşlem Tarihi";
            this.islemtarihiDataGridViewTextBoxColumn.Name = "islemtarihiDataGridViewTextBoxColumn";
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            // 
            // parabirimiDataGridViewTextBoxColumn
            // 
            this.parabirimiDataGridViewTextBoxColumn.DataPropertyName = "parabirimi";
            this.parabirimiDataGridViewTextBoxColumn.HeaderText = "Para Birimi";
            this.parabirimiDataGridViewTextBoxColumn.Name = "parabirimiDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // islemturuDataGridViewTextBoxColumn
            // 
            this.islemturuDataGridViewTextBoxColumn.DataPropertyName = "islemturu";
            this.islemturuDataGridViewTextBoxColumn.HeaderText = "İşlem Türü";
            this.islemturuDataGridViewTextBoxColumn.Name = "islemturuDataGridViewTextBoxColumn";
            // 
            // tahsilatBindingSource1
            // 
            this.tahsilatBindingSource1.DataMember = "tahsilat";
            this.tahsilatBindingSource1.DataSource = this.onmuhasebeDataSet23;
            // 
            // onmuhasebeDataSet23
            // 
            this.onmuhasebeDataSet23.DataSetName = "onmuhasebeDataSet23";
            this.onmuhasebeDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tahsilatBindingSource
            // 
            this.tahsilatBindingSource.DataMember = "tahsilat";
            this.tahsilatBindingSource.DataSource = this.onmuhasebesmartDataSet24;
            // 
            // onmuhasebesmartDataSet24
            // 
            this.onmuhasebesmartDataSet24.DataSetName = "onmuhasebesmartDataSet24";
            this.onmuhasebesmartDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tahsilatTableAdapter
            // 
            this.tahsilatTableAdapter.ClearBeforeFill = true;
            // 
            // tahsilatTableAdapter1
            // 
            this.tahsilatTableAdapter1.ClearBeforeFill = true;
            // 
            // borctahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 299);
            this.Name = "borctahsilat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borç/Alacak Tahsilatı";
            this.Load += new System.EventHandler(this.borctahsilat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebeDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahsilatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartDataSet24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aktarToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox cariadi;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox bakiye;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox evrakno;
        public System.Windows.Forms.TextBox tutar;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox aciklama;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker islemtarihi;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox islemturu;
        public System.Windows.Forms.ComboBox parabirimi;
        public onmuhasebesmartDataSet24 onmuhasebesmartDataSet24;
        public System.Windows.Forms.BindingSource tahsilatBindingSource;
        public onmuhasebesmartDataSet24TableAdapters.tahsilatTableAdapter tahsilatTableAdapter;
        private System.Windows.Forms.Button button5;
        private onmuhasebeDataSet23 onmuhasebeDataSet23;
        private System.Windows.Forms.BindingSource tahsilatBindingSource1;
        private onmuhasebeDataSet23TableAdapters.tahsilatTableAdapter tahsilatTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evraknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parabirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemturuDataGridViewTextBoxColumn;

    }
}