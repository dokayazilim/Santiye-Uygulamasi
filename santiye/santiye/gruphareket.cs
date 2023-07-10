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
    public partial class gruphareket : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public gruphareket()
        {
            InitializeComponent();
        }

        private void gruphareket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gruplarDataSet5.gruphareket' table. You can move, or remove it, as needed.
            this.gruphareketTableAdapter1.Fill(this.gruplarDataSet5.gruphareket);
            // TODO: This line of code loads data into the 'gruplarDataSet3.gruphareket' table. You can move, or remove it, as needed.
            this.gruphareketTableAdapter.Fill(this.gruplarDataSet3.gruphareket);

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }

            toplamborc.Text = sum.ToString();

            double dum = 0;
            for (int d = 0; d < dataGridView1.Rows.Count; ++d)
            {
                dum += Convert.ToDouble(dataGridView1.Rows[d].Cells[6].Value);
            }

            toplamalacak.Text = dum.ToString();

            bakiye.Text = ((sum - dum)).ToString();

        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        int i = 0;
        int bassayi = 1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslik = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            Font altbaslik = new System.Drawing.Font("Arial", 6, FontStyle.Regular);

            System.Drawing.Printing.PageSettings p = printDocument1.DefaultPageSettings;
            int x = 140, y = 140, say = dataGridView1.Rows.Count;

            e.Graphics.DrawString("Cari Adı", baslik, Brushes.Black, 95, 130);
            e.Graphics.DrawString("Grup Adı", baslik, Brushes.Black, 260, 130);
            e.Graphics.DrawString("İşlem Türü", baslik, Brushes.Black, 360, 130);
            e.Graphics.DrawString("Tarihi", baslik, Brushes.Black, 460, 130);
            e.Graphics.DrawString("Açıklama", baslik, Brushes.Black, 560, 130);
            e.Graphics.DrawString("Borç", baslik, Brushes.Black, 640, 130);
            e.Graphics.DrawString("Alacak", baslik, Brushes.Black, 730, 130);
            e.Graphics.DrawString("Bakiye", baslik, Brushes.Black, 830, 130);
            e.Graphics.DrawString("Borç :" + toplamborc.Text, baslik, Brushes.Black, 130, 710);
            e.Graphics.DrawString("Alacak :" + toplamalacak.Text, baslik, Brushes.Black, 350, 710);
            e.Graphics.DrawString("Bakiye :" + bakiye.Text, baslik, Brushes.Black, 580, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 750);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 790);

            while ((i < say))
            {
                x += 20;
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), altbaslik, Brushes.Black, 90, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), altbaslik, Brushes.Black, 260, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), altbaslik, Brushes.Black, 360, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), altbaslik, Brushes.Black, 480, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), altbaslik, Brushes.Black, 560, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), altbaslik, Brushes.Black, 640, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), altbaslik, Brushes.Black, 730, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), altbaslik, Brushes.Black, 830, x);
                

                e.Graphics.DrawString(bassayi.ToString(), altbaslik, Brushes.Black, 70, x);


                bassayi++;
                i++;
            }
        }

        private void tasksItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Landscape = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
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