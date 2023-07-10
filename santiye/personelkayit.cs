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
    public partial class personelkayit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public personelkayit()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            avansmaas a = new avansmaas();
            a.Show();
        }

        private void personelkayit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet46.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter1.Fill(this.onmuhasebeDataSet46.personel);
            label2.Visible = false;
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label2.Text == "avansmaas")
            {
                avansmaas frm2 = (avansmaas)Application.OpenForms["avansmaas"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.vergidairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm2.vergino.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();


                this.Hide();
            }
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

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenipersonel a = new yenipersonel();
            a.Show();
        }

        private void calendarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }
    }
}