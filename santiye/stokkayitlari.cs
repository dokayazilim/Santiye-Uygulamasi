using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace santiye
{
    public partial class stokkayitlari : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public stokkayitlari()
        {
            InitializeComponent();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tasksItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void stokkayitlari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet55.stokkayit' table. You can move, or remove it, as needed.
            this.stokkayitTableAdapter1.Fill(this.onmuhasebeDataSet55.stokkayit);
            label1.Visible = false;
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label1.Text == "alisislemi")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.labelalisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm2.labelsatisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.Hide();
            }
            if (label1.Text == "satisislemi")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.labelalisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm2.labelsatisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.Hide();
            }
            if (label1.Text == "alisiade")
            {
                alisiade frm2 = (alisiade)Application.OpenForms["alisiade"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.labelalisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm2.labelsatisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.Hide();
            }
            if (label1.Text == "satisiade")
            {
                satisiade frm2 = (satisiade)Application.OpenForms["satisiade"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.labelalisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm2.labelsatisfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.Hide();
            }
            if (label1.Text == "alisfatura")
            {
                alisfatura frm2 = (alisfatura)Application.OpenForms["alisfatura"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label1.Text == "satisfatura")
            {
                satisfatura frm2 = (satisfatura)Application.OpenForms["satisfatura"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label1.Text == "alisiadefatura")
            {
                alisiadefatura frm2 = (alisiadefatura)Application.OpenForms["alisiadefatura"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label1.Text == "satisiadefatura")
            {
                satisfaturaiade frm2 = (satisfaturaiade)Application.OpenForms["satisfaturaiade"];
                frm2.stokadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void calendarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenistok a = new yenistok();
            a.Show();
        }
    }
}