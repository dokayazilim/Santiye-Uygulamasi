using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace santiye
{
    public partial class saticilarhesabi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public saticilarhesabi()
        {
            InitializeComponent();
        }

        private void saticilarhesabi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet47.saticilar' table. You can move, or remove it, as needed.
            this.saticilarTableAdapter1.Fill(this.onmuhasebeDataSet47.saticilar);
        
            /*try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\onmuhasebesmart.mdf;Integrated Security=True";
                con.Open();

                string komut = "SELECT bakiye, CONVERT(decimal(10,5), borc) + CONVERT(decimal(10,5), alacak) AS bakiye FROM saticilar";
                string komut = "SELECT borc, borc * 3 AS bakiye FROM saticilar";


                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
                con.Close();



            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }*/          
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            borcekle a = new borcekle();
            a.Show();
        }

        private void tasksItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        int i = 0;
        int bassayi = 1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslik = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            Font altbaslik = new System.Drawing.Font("Arial", 8, FontStyle.Regular);

            System.Drawing.Printing.PageSettings p = printDocument1.DefaultPageSettings;
            int x = 140, y = 140, say = dataGridView1.Rows.Count;

            e.Graphics.DrawString("Cari Ünvan", baslik, Brushes.Black, 95, 130);
            e.Graphics.DrawString("Cari Kodu", baslik, Brushes.Black, 260, 130);
            e.Graphics.DrawString("Özel Kodu", baslik, Brushes.Black, 360, 130);
            e.Graphics.DrawString("Yetkili", baslik, Brushes.Black, 460, 130);
            e.Graphics.DrawString("İl/İlçe", baslik, Brushes.Black, 560, 130);
            e.Graphics.DrawString("Borç", baslik, Brushes.Black, 640, 130);
            e.Graphics.DrawString("Alacak", baslik, Brushes.Black, 730, 130);
            e.Graphics.DrawString("Bakiye", baslik, Brushes.Black, 830, 130);
            e.Graphics.DrawString("Para Birimi", baslik, Brushes.Black, 920, 130);
            e.Graphics.DrawString("Durumu", baslik, Brushes.Black, 1010, 130);
            e.Graphics.DrawString("", baslik, Brushes.Black, 125, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 125, 750);
            e.Graphics.DrawString("", baslik, Brushes.Black, 125, 790);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 750);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 790);

            while ((i < say))
            {
                x += 20;
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), altbaslik, Brushes.Black, 90, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), altbaslik, Brushes.Black, 260, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), altbaslik, Brushes.Black, 360, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), altbaslik, Brushes.Black, 460, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString() + " " + dataGridView1.Rows[i].Cells[5].Value.ToString(), altbaslik, Brushes.Black, 560, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[8].Value.ToString(), altbaslik, Brushes.Black, 640, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[9].Value.ToString(), altbaslik, Brushes.Black, 730, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[10].Value.ToString(), altbaslik, Brushes.Black, 830, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[11].Value.ToString(), altbaslik, Brushes.Black, 920, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[12].Value.ToString(), altbaslik, Brushes.Black, 1010, x);
                e.Graphics.DrawString(bassayi.ToString(), altbaslik, Brushes.Black, 70, x);


                bassayi++;
                i++;
            }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Landscape = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
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