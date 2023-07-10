namespace santiye
{
    partial class aktar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aktar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabletpc = new System.Windows.Forms.RadioButton();
            this.onlinebulut = new System.Windows.Forms.RadioButton();
            this.pc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabletpc);
            this.groupBox1.Controls.Add(this.onlinebulut);
            this.groupBox1.Controls.Add(this.pc);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // tabletpc
            // 
            this.tabletpc.AutoSize = true;
            this.tabletpc.Location = new System.Drawing.Point(19, 67);
            this.tabletpc.Name = "tabletpc";
            this.tabletpc.Size = new System.Drawing.Size(72, 17);
            this.tabletpc.TabIndex = 3;
            this.tabletpc.TabStop = true;
            this.tabletpc.Text = "Tablet PC";
            this.tabletpc.UseVisualStyleBackColor = true;
            // 
            // onlinebulut
            // 
            this.onlinebulut.AutoSize = true;
            this.onlinebulut.Location = new System.Drawing.Point(19, 44);
            this.onlinebulut.Name = "onlinebulut";
            this.onlinebulut.Size = new System.Drawing.Size(82, 17);
            this.onlinebulut.TabIndex = 2;
            this.onlinebulut.TabStop = true;
            this.onlinebulut.Text = "Online Bulut";
            this.onlinebulut.UseVisualStyleBackColor = true;
            // 
            // pc
            // 
            this.pc.AutoSize = true;
            this.pc.Location = new System.Drawing.Point(19, 21);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(69, 17);
            this.pc.TabIndex = 1;
            this.pc.TabStop = true;
            this.pc.Text = "Bilgisayar";
            this.pc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aktar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(125, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 142);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(235, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(235, 180);
            this.Name = "aktar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedek Al";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pc;
        private System.Windows.Forms.RadioButton onlinebulut;
        private System.Windows.Forms.RadioButton tabletpc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}