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
    public partial class bankahesap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bankahesap()
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

        private void bankahesap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet70.bankahesap' table. You can move, or remove it, as needed.
            this.bankahesapTableAdapter2.Fill(this.onmuhasebeDataSet70.bankahesap);
            // TODO: This line of code loads data into the 'onmuhasebeDataSet20.bankahesap' table. You can move, or remove it, as needed.
            this.bankahesapTableAdapter1.Fill(this.onmuhasebeDataSet20.bankahesap);
            label7.Visible = false;
       

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label7.Text == "gelenhavale")
            {
                gelenhavale frm2 = (gelenhavale)Application.OpenForms["gelenhavale"];
                frm2.serino.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "gidenhavale")
            {
                gidenhavale frm2 = (gidenhavale)Application.OpenForms["gidenhavale"];
                frm2.serino.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "bankakredi")
            {
                bankakredi frm2 = (bankakredi)Application.OpenForms["bankakredi"];
                frm2.serino.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "paracekme")
            {
                paracekme frm2 = (paracekme)Application.OpenForms["paracekme"];
                frm2.serino.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "parayatirma")
            {
                parayatirma frm2 = (parayatirma)Application.OpenForms["parayatirma"];
                frm2.serino.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "bankaparatransfer")
            {
                bankabanka frm2 = (bankabanka)Application.OpenForms["bankabanka"];
                frm2.bankaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "bankaparatransferdiger")
            {
                bankabanka frm2 = (bankabanka)Application.OpenForms["bankabanka"];
                frm2.bankaadidiger.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapnodiger.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadidiger.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiyediger.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadidiger.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "bankacari")
            {
                bankacari frm2 = (bankacari)Application.OpenForms["bankacari"];
                frm2.bankaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "caribanka")
            {
                caribanka frm2 = (caribanka)Application.OpenForms["caribanka"];
                frm2.bankaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadidiger.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "alinancek")
            {
                alinancek frm2 = (alinancek)Application.OpenForms["alinancek"];
                frm2.serino.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
            if (label7.Text == "verilencek")
            {
                verilencek frm2 = (verilencek)Application.OpenForms["verilencek"];
                frm2.serino.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenibankahesabi a = new yenibankahesabi();
            a.Show();
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
    }
}