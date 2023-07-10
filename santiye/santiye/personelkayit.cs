using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.OleDb;

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

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


            if (label2.Text == "avansmaas")
            {
                avansmaas frm2 = (avansmaas)Application.OpenForms["avansmaas"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.vergidairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm2.vergino.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();


                this.Hide();
            }
            if (label2.Text == "satisislemi")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                


                this.Hide();
            }
            if (label2.Text == "satisiadeislemi")
            {
                satisiade frm2 = (satisiade)Application.OpenForms["satisiade"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();



                this.Hide();
            }
            if (label2.Text == "alisiadeislemi")
            {
                alisiade frm2 = (alisiade)Application.OpenForms["alisiade"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();



                this.Hide();
            }
            if (label2.Text == "alisislemi")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();



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

        private void trashItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from personel where adisoyadi='" + textBox1.Text + "'");

                    komut.Connection = baglan;

                    komut.ExecuteNonQuery();

                    baglan.Close();

                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    textBox1.Clear();




                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}