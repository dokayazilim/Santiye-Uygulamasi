namespace santiye
{
    partial class bankakarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankakarti));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeismiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankakartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebeDataSet21 = new santiye.onmuhasebeDataSet21();
            this.bankakartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onmuhasebesmartDataSet22 = new santiye.onmuhasebesmartDataSet22();
            this.bankakartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.subeismird = new System.Windows.Forms.RadioButton();
            this.bankaadird = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.subeismi = new System.Windows.Forms.TextBox();
            this.bankaadi = new System.Windows.Forms.TextBox();
            this.bankakodu = new System.Windows.Forms.TextBox();
            this.bankakodurd = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bankakartTableAdapter = new santiye.onmuhasebesmartDataSet22TableAdapters.bankakartTableAdapter();
            this.bankakartTableAdapter1 = new santiye.onmuhasebeDataSet21TableAdapters.bankakartTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankakartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebeDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankakartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankakartiBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapnoDataGridViewTextBoxColumn,
            this.subeadiDataGridViewTextBoxColumn,
            this.subeismiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bankakartBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(802, 172);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hesapnoDataGridViewTextBoxColumn
            // 
            this.hesapnoDataGridViewTextBoxColumn.DataPropertyName = "hesapno";
            this.hesapnoDataGridViewTextBoxColumn.HeaderText = "Hesap No";
            this.hesapnoDataGridViewTextBoxColumn.Name = "hesapnoDataGridViewTextBoxColumn";
            // 
            // subeadiDataGridViewTextBoxColumn
            // 
            this.subeadiDataGridViewTextBoxColumn.DataPropertyName = "subeadi";
            this.subeadiDataGridViewTextBoxColumn.HeaderText = "Banka Adı";
            this.subeadiDataGridViewTextBoxColumn.Name = "subeadiDataGridViewTextBoxColumn";
            // 
            // subeismiDataGridViewTextBoxColumn
            // 
            this.subeismiDataGridViewTextBoxColumn.DataPropertyName = "subeismi";
            this.subeismiDataGridViewTextBoxColumn.HeaderText = "Şube İsmi";
            this.subeismiDataGridViewTextBoxColumn.Name = "subeismiDataGridViewTextBoxColumn";
            // 
            // bankakartBindingSource1
            // 
            this.bankakartBindingSource1.DataMember = "bankakart";
            this.bankakartBindingSource1.DataSource = this.onmuhasebeDataSet21;
            // 
            // onmuhasebeDataSet21
            // 
            this.onmuhasebeDataSet21.DataSetName = "onmuhasebeDataSet21";
            this.onmuhasebeDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankakartBindingSource
            // 
            this.bankakartBindingSource.DataMember = "bankakart";
            this.bankakartBindingSource.DataSource = this.onmuhasebesmartDataSet22;
            // 
            // onmuhasebesmartDataSet22
            // 
            this.onmuhasebesmartDataSet22.DataSetName = "onmuhasebesmartDataSet22";
            this.onmuhasebesmartDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankakartiBindingSource
            // 
            this.bankakartiBindingSource.DataMember = "bankakarti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "Close.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(756, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 36);
            this.button3.TabIndex = 6;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(617, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Filtrele";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // subeismird
            // 
            this.subeismird.AutoSize = true;
            this.subeismird.Location = new System.Drawing.Point(514, 22);
            this.subeismird.Name = "subeismird";
            this.subeismird.Size = new System.Drawing.Size(68, 17);
            this.subeismird.TabIndex = 6;
            this.subeismird.TabStop = true;
            this.subeismird.Text = "Şube Adı";
            this.subeismird.UseVisualStyleBackColor = true;
            // 
            // bankaadird
            // 
            this.bankaadird.AutoSize = true;
            this.bankaadird.Location = new System.Drawing.Point(420, 22);
            this.bankaadird.Name = "bankaadird";
            this.bankaadird.Size = new System.Drawing.Size(74, 17);
            this.bankaadird.TabIndex = 5;
            this.bankaadird.TabStop = true;
            this.bankaadird.Text = "Banka Adı";
            this.bankaadird.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "gtk-refresh.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(711, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 36);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "kaydet.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(666, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 36);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subeismi
            // 
            this.subeismi.Location = new System.Drawing.Point(513, 20);
            this.subeismi.Name = "subeismi";
            this.subeismi.Size = new System.Drawing.Size(147, 20);
            this.subeismi.TabIndex = 3;
            // 
            // bankaadi
            // 
            this.bankaadi.Location = new System.Drawing.Point(305, 20);
            this.bankaadi.Name = "bankaadi";
            this.bankaadi.Size = new System.Drawing.Size(137, 20);
            this.bankaadi.TabIndex = 2;
            // 
            // bankakodu
            // 
            this.bankakodu.Location = new System.Drawing.Point(97, 20);
            this.bankakodu.Name = "bankakodu";
            this.bankakodu.Size = new System.Drawing.Size(120, 20);
            this.bankakodu.TabIndex = 1;
            // 
            // bankakodurd
            // 
            this.bankakodurd.AutoSize = true;
            this.bankakodurd.Location = new System.Drawing.Point(313, 22);
            this.bankakodurd.Name = "bankakodurd";
            this.bankakodurd.Size = new System.Drawing.Size(84, 17);
            this.bankakodurd.TabIndex = 4;
            this.bankakodurd.TabStop = true;
            this.bankakodurd.Text = "Banka Kodu";
            this.bankakodurd.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.subeismird);
            this.groupBox2.Controls.Add(this.bankaadird);
            this.groupBox2.Controls.Add(this.bankakodurd);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrele";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ara :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şube Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banka Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.subeismi);
            this.groupBox1.Controls.Add(this.bankaadi);
            this.groupBox1.Controls.Add(this.bankakodu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap No :";
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
            this.hesapMakinesiToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
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
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bankakartTableAdapter
            // 
            this.bankakartTableAdapter.ClearBeforeFill = true;
            // 
            // bankakartTableAdapter1
            // 
            this.bankakartTableAdapter1.ClearBeforeFill = true;
            // 
            // bankakarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 362);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 362);
            this.Name = "bankakarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Banka Kartı";
            this.Load += new System.EventHandler(this.bankakarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankakartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebeDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankakartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onmuhasebesmartDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankakartiBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bankakartiBindingSource;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton subeismird;
        private System.Windows.Forms.RadioButton bankaadird;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox subeismi;
        private System.Windows.Forms.TextBox bankaadi;
        private System.Windows.Forms.TextBox bankakodu;
        private System.Windows.Forms.RadioButton bankakodurd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private onmuhasebesmartDataSet22 onmuhasebesmartDataSet22;
        private System.Windows.Forms.BindingSource bankakartBindingSource;
        private onmuhasebesmartDataSet22TableAdapters.bankakartTableAdapter bankakartTableAdapter;
        private onmuhasebeDataSet21 onmuhasebeDataSet21;
        private System.Windows.Forms.BindingSource bankakartBindingSource1;
        private onmuhasebeDataSet21TableAdapters.bankakartTableAdapter bankakartTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeismiDataGridViewTextBoxColumn;
    }
}