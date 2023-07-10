using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace santiye
{
    public partial class fisislemi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fisislemi()
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

        private void fisislemi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet34.fisislemi' table. You can move, or remove it, as needed.
            this.fisislemiTableAdapter1.Fill(this.onmuhasebeDataSet34.fisislemi);
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "INSERT INTO fisislemi(tarih,fisno,fisturu,urunadi,carihesap,tutar,parabirimi,aciklama,durum)VALUES('" + tarih.Text + "','" + faturano.Text + "','" + fisturu.Text + "','" + stokadi.Text + "','" + cariadi.Text + "','" + "" + "','" + "" + "','" + "" + "','" + durum.Text + "')";

                    /*string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + kasaadi.Text + "')";
                    string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + kasaadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";*/

                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    /*SqlCommand komutsatir3 = new SqlCommand(komut3, con);
                    SqlCommand komutsatir4 = new SqlCommand(komut4, con);*/
                    komutsatir.Connection = con;
                    /*komutsatir3.Connection = con;
                    komutsatir4.Connection = con;*/

                    komutsatir.ExecuteNonQuery();
                    /*komutsatir3.ExecuteNonQuery();
                    komutsatir4.ExecuteNonQuery();*/
                    con.Close();
                    listele();



                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from fisislemi", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {


           

                if (durum.Text == "Borçlu")
                {

                    string col1, col2, col3, col4, col5, col6, col7, col8, col9;

                    col1 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                    col2 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                    col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
                    col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
                    col5 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
                    col6 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
                    col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
                    col8 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                    col9 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update fisislemi set tarih='" + Convert.ToString(col1) + "',fisno='" + Convert.ToString(col2) + "',fisturu='" + Convert.ToString(col3) + "',urunadi='" + Convert.ToString(col4) + "',carihesap='" + Convert.ToString(col5) + "',tutar='" + Convert.ToString(col6) + "',parabirimi='" + Convert.ToString(col7) + "',aciklama='" + Convert.ToString(col8) + "',durum='" + Convert.ToString(col9) + "' where fisno='" + textBox1.Text + "'";
                        string komut2 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "BELGESİZ İŞLEM" + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col8) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col6) + "','" + "0" + "','" + Convert.ToString(col7) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col5) + "','" + "MERKEZ" + "')";
                        /*string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + kasaadi.Text + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + kasaadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";*/

                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        /*SqlCommand komutsatir3 = new SqlCommand(komut3, con);
                        SqlCommand komutsatir4 = new SqlCommand(komut4, con);*/
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        /*komutsatir3.Connection = con;
                        komutsatir4.Connection = con;*/

                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        /*komutsatir3.ExecuteNonQuery();
                        komutsatir4.ExecuteNonQuery();*/
                        con.Close();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                    }

                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());


                    }
                }
                else if (durum.Text == "Alacaklı")
                {

                    string col1, col2, col3, col4, col5, col6, col7, col8, col9;

                    col1 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                    col2 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                    col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
                    col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
                    col5 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
                    col6 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
                    col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
                    col8 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                    col9 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update fisislemi set tarih='" + Convert.ToString(col1) + "',fisno='" + Convert.ToString(col2) + "',fisturu='" + Convert.ToString(col3) + "',urunadi='" + Convert.ToString(col4) + "',carihesap='" + Convert.ToString(col5) + "',tutar='" + Convert.ToString(col6) + "',parabirimi='" + Convert.ToString(col7) + "',aciklama='" + Convert.ToString(col8) + "',durum='" + Convert.ToString(col9) + "' where fisno='" + textBox1.Text + "'";
                        string komut2 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "BELGESİZ İŞLEM" + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col8) + "','" + "0" + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col6) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col5) + "','" + "MERKEZ" + "')";
                        /*string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + kasaadi.Text + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + kasaadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";*/

                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        /*SqlCommand komutsatir3 = new SqlCommand(komut3, con);
                        SqlCommand komutsatir4 = new SqlCommand(komut4, con);*/
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        /*komutsatir3.Connection = con;
                        komutsatir4.Connection = con;*/

                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        /*komutsatir3.ExecuteNonQuery();
                        komutsatir4.ExecuteNonQuery();*/
                        con.Close();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                    }

                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());


                    }
                }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iSave.PerformClick();
            }

            else if (e.KeyCode == Keys.F5)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {
                iExit.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                iFind.PerformClick();
            }
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            iskonto a = new iskonto();
            a.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15, col16, col17, col18, col19;

            col1 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col2 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col9 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
        


            // Create string to draw.
            String drawString = "";
            String drawString2 = "";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont2 = new Font("Arial", 8);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);
            Font drawFont3 = new Font("Arial", 10);
            SolidBrush drawBrush3 = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x = 50.0F;
            float y = 35.0F;
            float width = 750.0F;
            float height = 200.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);
            float a = 50.0F;
            float b = 235.0F;
            float widt = 750.0F;
            float heigh = 350.0F;
            RectangleF drawRect2 = new RectangleF(a, b, widt, heigh);
            float c = 50.0F;
            float d = 235.0F;
            float wid = 750.0F;
            float heig = 70.0F;
            RectangleF drawRect3 = new RectangleF(c, d, wid, heig);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
            Pen blackPen2 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen2, a, b, widt, heigh);
            Pen blackPen3 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen3, c, d, wid, heig);

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
            String drawyazi2 = "Tarih : " + tarih.Text;
            String drawyazi3 = "Fiş No : " + col2;
            String drawyazi4 = "Fiş Türü :" + col3;
            String drawyazi5 = "";
            String drawyazi6 = "";
            String drawyazi7 = "ÜRÜN ADI";
            String drawyazi8 = "DURUMU";
            String drawyazi9 = "AÇIKLAMA";
            String drawyazi10 = "TUTAR";
            String drawyazi11 = col4;
            String drawyazi12 = col9;
            String drawyazi13 = col8;
            String drawyazi14 = col6;
            String drawyazi15 = "";
            String drawyazi16 = "";
            String drawyazi17 = "";
            String drawyazi18 = "";
            String drawyazi19 = "";
            String drawyazi20 =  "";
            String drawyazi21 = "";
            String drawyazi22 = "";


            // Create font and brush.
            Font drawFon = new Font("Arial", 12);
            SolidBrush drawfirca = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(350.0F, 100.0F);
            PointF drawPoint2 = new PointF(50.0F, 180.0F);
            PointF drawPoint3 = new PointF(50.5F, 210.0F);
            PointF drawPoint4 = new PointF(50.0F, 150.0F);
            PointF drawPoint5 = new PointF(590.0F, 210.0F);
            PointF drawPoint6 = new PointF(590.0F, 240.0F);
            PointF drawPoint7 = new PointF(200.0F, 240.0F);
            PointF drawPoint8 = new PointF(480.0F, 240.0F);
            PointF drawPoint9 = new PointF(620.0F, 240.0F);
            PointF drawPoint10 = new PointF(750.0F, 240.0F);
            PointF drawPoint11 = new PointF(200.0F, 280.0F);
            PointF drawPoint12 = new PointF(480.0F, 280.0F);
            PointF drawPoint13 = new PointF(620.0F, 280.0F);
            PointF drawPoint14 = new PointF(750.0F, 280.0F);
            PointF drawPoint15 = new PointF(480.0F, 350.0F);
            PointF drawPoint16 = new PointF(480.0F, 390.0F);
            PointF drawPoint17 = new PointF(480.0F, 430.0F);
            PointF drawPoint18 = new PointF(480.0F, 470.0F);
            PointF drawPoint19 = new PointF(700.0F, 350.0F);
            PointF drawPoint20 = new PointF(700.0F, 390.0F);
            PointF drawPoint21 = new PointF(700.0F, 430.0F);
            PointF drawPoint22 = new PointF(700.0F, 470.0F);



            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
            e.Graphics.DrawString(drawString2, drawFont, drawBrush, drawRect2, drawFormat3);
            e.Graphics.DrawString(drawString2, drawFont, drawBrush, drawRect3, drawFormat4);
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


            /*Image img = logo.Image;
            System.Drawing.Image i = System.Drawing.Image.FromFile(img.ToString());
            Point p = new Point(150,150);
            e.Graphics.DrawImage(i, p);*/
            int X = printDocument1.DefaultPageSettings.Margins.Left;
            int Y = printDocument1.DefaultPageSettings.Margins.Top;
            /*int Genislik = logo.Width;
            int Yukseklik = logo.Height;
            e.Graphics.DrawImage(logo.Image, X, Y, Genislik, Yukseklik);*/ 
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        int i = 0;
        int bassayi = 1;
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslik = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            Font altbaslik = new System.Drawing.Font("Arial", 8, FontStyle.Regular);

            System.Drawing.Printing.PageSettings p = printDocument1.DefaultPageSettings;
            int x = 140, y = 140, say = dataGridView1.Rows.Count;

            e.Graphics.DrawString("Cari Adı", baslik, Brushes.Black, 125, 130);
            e.Graphics.DrawString("Tarih", baslik, Brushes.Black, 280, 130);
            e.Graphics.DrawString("Fiş No", baslik, Brushes.Black, 380, 130);
            e.Graphics.DrawString("Fiş Türü", baslik, Brushes.Black, 480, 130);
            e.Graphics.DrawString("Ürün/İş Adı", baslik, Brushes.Black, 580, 130);
            e.Graphics.DrawString("Tutar", baslik, Brushes.Black, 680, 130);
            e.Graphics.DrawString("Para Birimi", baslik, Brushes.Black, 760, 130);
            e.Graphics.DrawString("Açıklama", baslik, Brushes.Black, 860, 130);
            e.Graphics.DrawString("Durumu", baslik, Brushes.Black, 940, 130);
            e.Graphics.DrawString("", baslik, Brushes.Black, 1020, 130);
            e.Graphics.DrawString("", baslik, Brushes.Black, 125, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 125, 750);
            e.Graphics.DrawString("", baslik, Brushes.Black, 125, 790);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 710);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 750);
            e.Graphics.DrawString("", baslik, Brushes.Black, 580, 790);

            while ((i < say))
            {
                x += 20;
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), altbaslik, Brushes.Black, 120, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), altbaslik, Brushes.Black, 280, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), altbaslik, Brushes.Black, 380, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), altbaslik, Brushes.Black, 480, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), altbaslik, Brushes.Black, 580, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), altbaslik, Brushes.Black, 680, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), altbaslik, Brushes.Black, 760, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), altbaslik, Brushes.Black, 860, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[8].Value.ToString(), altbaslik, Brushes.Black, 940, x);
                
                e.Graphics.DrawString(bassayi.ToString(), altbaslik, Brushes.Black, 100, x);


                bassayi++;
                i++;
            }
        }

        private void printDocument2_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Landscape = true;
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.printPreviewDialog2.ShowDialog();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            printDocument2.Print();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "fisislemi";
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

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenicari a = new yenicari();
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
                    OleDbCommand komut = new OleDbCommand("delete from fisislemi where fisno='" + textBox1.Text + "'");

                    komut.Connection = baglan;

                    komut.ExecuteNonQuery();

                    baglan.Close();
                    listele();
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