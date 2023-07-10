using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Diagnostics;
using System.IO;

using Microsoft.CSharp;
using System.Data.SqlClient;




namespace santiye
{
    public partial class carihareket : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public carihareket()
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

        private void carihareket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet26.carihareket' table. You can move, or remove it, as needed.
            this.carihareketTableAdapter1.Fill(this.onmuhasebeDataSet26.carihareket);
            label6.Visible = false;

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }

            toplamborc.Text = sum.ToString();

            double dum = 0;
            for (int d = 0; d < dataGridView1.Rows.Count; ++d)
            {
                dum += Convert.ToDouble(dataGridView1.Rows[d].Cells[7].Value);
            }

            toplamalacak.Text = dum.ToString();

            bakiye.Text = ((sum - dum)).ToString();
           

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
            e.Graphics.DrawString("Tarih", baslik, Brushes.Black, 260, 130);
            e.Graphics.DrawString("İşlem Türü", baslik, Brushes.Black, 360, 130);
            e.Graphics.DrawString("Açıklama", baslik, Brushes.Black, 460, 130);
            e.Graphics.DrawString("Evrak No", baslik, Brushes.Black, 560, 130);
            e.Graphics.DrawString("KDV'si(Borç)", baslik, Brushes.Black, 640, 130);
            e.Graphics.DrawString("KDV' si(Ala.)", baslik, Brushes.Black, 730, 130);
            e.Graphics.DrawString("Borç", baslik, Brushes.Black, 830, 130);
            e.Graphics.DrawString("Alacak", baslik, Brushes.Black, 920, 130);
            e.Graphics.DrawString("Ödeme Yeri", baslik, Brushes.Black, 1010, 130);
            e.Graphics.DrawString("Borç :" + toplamborc.Text, baslik, Brushes.Black, 130, 710);
            e.Graphics.DrawString("Alacak :" + toplamalacak.Text, baslik, Brushes.Black, 350, 710);
            e.Graphics.DrawString("Bakiye :" + bakiye.Text, baslik, Brushes.Black, 580, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 750);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 790);

            while ((i < say))
            {
                x += 20;
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[11].Value.ToString(), altbaslik, Brushes.Black, 90, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), altbaslik, Brushes.Black, 260, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), altbaslik, Brushes.Black, 360, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), altbaslik, Brushes.Black, 460, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), altbaslik, Brushes.Black, 560, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), altbaslik, Brushes.Black, 640, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), altbaslik, Brushes.Black, 730, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), altbaslik, Brushes.Black, 830, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), altbaslik, Brushes.Black, 920, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[12].Value.ToString(), altbaslik, Brushes.Black, 1010, x);
                e.Graphics.DrawString(bassayi.ToString(), altbaslik, Brushes.Black, 70, x);


                bassayi++;
                i++;
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Landscape = true;
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            /*Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true; 

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1; 

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            StartRow++;

            /*dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                { 

                    try
                    {



                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                       
                        
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.EntireColumn.AutoFit();
                        
                        
                    }

                    catch
                    {

                        ;

                    }

                } 

            }*/
        }
        
        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15;

            col1 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col2 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col9 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col10 = dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col11 = dataGridView1[10, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col12 = dataGridView1[11, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col13 = dataGridView1[12, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col14 = dataGridView1[13, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col15 = dataGridView1[14, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...*/



            // Create string to draw.
            String drawString = "";
            String drawString2 = "";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont2 = new Font("Arial", 8);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);
            Font drawFont3 = new Font("Arial", 7);
            SolidBrush drawBrush3 = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            /*float x = 50.0F;
            float y = 35.0F;
            float width = 850.0F;
            float height = 100.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);*/
            /*float a = 50.0F;
            float b = 115.0F;
            float widt = 750.0F;
            float heigh = 200.0F;
            RectangleF drawRect2 = new RectangleF(a, b, widt, heigh);
            float c = 50.0F;
            float d = 115.0F;
            float wid = 750.0F;
            float heig = 30.0F;
            RectangleF drawRect3 = new RectangleF(c, d, wid, heig);*/

            // Draw rectangle to screen.
            /*Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);*/
            /*Pen blackPen2 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen2, a, b, widt, heigh);
            Pen blackPen3 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen3, c, d, wid, heig);*/

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            StringFormat drawFormat2 = new StringFormat();
            drawFormat2.Alignment = StringAlignment.Near;
            StringFormat drawFormat3 = new StringFormat();
            drawFormat3.Alignment = StringAlignment.Center;
            StringFormat drawFormat4 = new StringFormat();
            drawFormat4.Alignment = StringAlignment.Center;

            //yazı draw string...


            /*float kdvoran = float.Parse(col11);
            double fiyat = Convert.ToDouble(col10);
            double brm = Convert.ToDouble(col9);
            double kdvislem = brm * fiyat * (1 + (kdvoran / 100));
            double kdvsonuc = brm * (fiyat * kdvoran) / 100;

            double ttr = brm * fiyat;

            double isk = Convert.ToDouble(col13);
            double isk2 = Convert.ToDouble(col14);
            double isk3 = Convert.ToDouble(col15);
            double isk4 = Convert.ToDouble(col16);
            double isk5 = Convert.ToDouble(col17);

            double isktopla = isk + isk2 + isk3 + isk4 + isk5;
            double iskbolum = (100 - isktopla) / 100;
            double isksonuc = kdvislem * iskbolum;

            string gun;
            gun = DateTime.Now.ToShortDateString();*/

            String drawyazi = "";
            String drawyazi2 = "Tarih :";
            String drawyazi3 = "";
            String drawyazi4 = "";
            String drawyazi5 = "";
            String drawyazi6 = "";
            String drawyazi7 = "Sayın, ";
            String drawyazi8 = "Ali bey";
            String drawyazi9 = "111111111";
            String drawyazi10 = "ÖZÜ : Hesap Bakiyeniz Hakkında";
            String drawyazi11 = "Şirketimizdeki cari hesabınız - tarihi itibariyle " + bakiye.Text + " TL bakiyesi vermektedir.";
            String drawyazi12 = "Mutabık olup olmadığınızı aşağıdaki bölümü doldurup kaşe ve imzalayarak tarafımıza göndermek";
            String drawyazi13 = "suretiyle bildirmenizi rica ederiz.";
            String drawyazi14 = "Saygılarımızla.";
            String drawyazi15 = "Yanılma ve Unutma Müstesnadır";
            String drawyazi16 = "1) Uygunluk veya itirazınızı 10 gün içerisinde bildirmediğiniz takdirde T.T.K' nın 92. maddesi gereği";
            String drawyazi17 = "mutabık sayılacağınızı hatırlatırız.";
            String drawyazi18 = "2) Bakiyede mutabık olmadığınız takdirde bir hesap ekstrenizin gönderilmesini rica ederiz.";
            String drawyazi19 = "DEMO LTD.ŞTİ.";
            String drawyazi20 = "KİLİS";
            String drawyazi21 = "Nezdimizdeki cari hesabınızın - tarihi itibari ile ........................... BORÇ/ALACAK bakiyesi";
            String drawyazi22 = "ile mutabık OLDUĞUMUZU/OLMADIĞIMIZI bildiririz.";
            String drawyazi23 = "Saygılarımızla.";


            // Create font and brush.
            Font drawFon = new Font("Arial", 12);
            SolidBrush drawfirca = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(350.0F, 100.0F);
            PointF drawPoint2 = new PointF(640.0F, 120.0F);
            PointF drawPoint3 = new PointF(50.5F, 210.0F);
            PointF drawPoint4 = new PointF(50.0F, 100.0F);
            PointF drawPoint5 = new PointF(590.0F, 210.0F);
            PointF drawPoint6 = new PointF(590.0F, 120.0F);
            PointF drawPoint7 = new PointF(100.0F, 120.0F);
            PointF drawPoint8 = new PointF(100.0F, 150.0F);
            PointF drawPoint9 = new PointF(100.0F, 180.0F);
            PointF drawPoint10 = new PointF(150.0F, 250.0F);
            PointF drawPoint11 = new PointF(305.0F, 280.0F);
            PointF drawPoint12 = new PointF(390.0F, 320.0F);
            PointF drawPoint13 = new PointF(145.0F, 340.0F);
            PointF drawPoint14 = new PointF(100.0F, 380.0F);
            PointF drawPoint15 = new PointF(40.0F, 500.0F);
            PointF drawPoint16 = new PointF(40.0F, 540.0F);
            PointF drawPoint17 = new PointF(40.0F, 560.0F);
            PointF drawPoint18 = new PointF(40.0F, 610.0F);
            PointF drawPoint19 = new PointF(40.0F, 740.0F);
            PointF drawPoint20 = new PointF(40.0F, 760.0F);
            PointF drawPoint21 = new PointF(40.0F, 810.0F);
            PointF drawPoint22 = new PointF(40.0F, 830.0F);
            PointF drawPoint23 = new PointF(40.0F, 870.0F);


            // Draw string to screen.
            /*e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);*/
            /*e.Graphics.DrawString(drawString2, drawFont, drawBrush, drawRect2, drawFormat3);*/
            /*e.Graphics.DrawString(drawString2, drawFont, drawBrush, drawRect3, drawFormat4);*/
            e.Graphics.DrawString(drawyazi, drawFon, drawBrush, drawPoint, drawFormat2);
            e.Graphics.DrawString(drawyazi2, drawFon, drawBrush, drawPoint2, drawFormat2);
            e.Graphics.DrawString(drawyazi3, drawFon, drawBrush, drawPoint3, drawFormat2);
            e.Graphics.DrawString(drawyazi4, drawFon, drawBrush, drawPoint4, drawFormat2);
            e.Graphics.DrawString(drawyazi5, drawFon, drawBrush, drawPoint5, drawFormat2);
            e.Graphics.DrawString(drawyazi6, drawFon, drawBrush, drawPoint6, drawFormat2);
            e.Graphics.DrawString(drawyazi7, drawFon, drawBrush, drawPoint7, drawFormat3);
            e.Graphics.DrawString(drawyazi8, drawFon, drawBrush, drawPoint8, drawFormat3);
            e.Graphics.DrawString(drawyazi9, drawFon, drawBrush, drawPoint9, drawFormat3);
            e.Graphics.DrawString(drawyazi10, drawFon, drawBrush, drawPoint10, drawFormat3);
            e.Graphics.DrawString(drawyazi11, drawFon, drawBrush, drawPoint11, drawFormat3);
            e.Graphics.DrawString(drawyazi12, drawFon, drawBrush, drawPoint12, drawFormat3);
            e.Graphics.DrawString(drawyazi13, drawFon, drawBrush, drawPoint13, drawFormat3);
            e.Graphics.DrawString(drawyazi14, drawFon, drawBrush, drawPoint14, drawFormat3);
            e.Graphics.DrawString(drawyazi15, drawFon, drawBrush, drawPoint15, drawFormat2);
            e.Graphics.DrawString(drawyazi16, drawFon, drawBrush, drawPoint16, drawFormat2);
            e.Graphics.DrawString(drawyazi17, drawFon, drawBrush, drawPoint17, drawFormat2);
            e.Graphics.DrawString(drawyazi18, drawFon, drawBrush, drawPoint18, drawFormat2);
            e.Graphics.DrawString(drawyazi19, drawFon, drawBrush, drawPoint19, drawFormat2);
            e.Graphics.DrawString(drawyazi20, drawFon, drawBrush, drawPoint20, drawFormat2);
            e.Graphics.DrawString(drawyazi21, drawFon, drawBrush, drawPoint21, drawFormat2);
            e.Graphics.DrawString(drawyazi22, drawFon, drawBrush, drawPoint22, drawFormat2);
            e.Graphics.DrawString(drawyazi23, drawFon, drawBrush, drawPoint23, drawFormat2);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            borcekle a = new borcekle();
            a.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenicari a = new yenicari();
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
        /*public void grupla()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\onmuhasebesmart.mdf;Integrated Security=True";
                con.Open();

                string komut = "SELECT aciklama FROM carihareket GROUP BY aciklama WITH CUBE";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                



            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        }*/
    }
}