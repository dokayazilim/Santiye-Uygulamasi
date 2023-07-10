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
    public partial class alinancek : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public alinancek()
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

        private void button3_Click(object sender, EventArgs e)
        {
                     

                if (bordrono.Text == "")
                {
                    MessageBox.Show("'Bordro No' alanı boş geçilemez.", "Uyarı");
                }
                else
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "INSERT INTO alinancek(bordrono,tarih,saat,aciklama,cariadi,evrakdurumu,serino,vadetarihi,borclu,odemeyeri,tutar,parabirimi,bankaadi,subeadi,hesapno)VALUES('" + bordrono.Text + "','" + tarih.Text + "','" + saat.Text + "','" + "" + "','" + cariadi.Text + "','" + "" + "','" + "" + "','" + vadetarihi.Text + "','" + cariadi.Text + "','" + "" + "','" + "" + "','" + "" + "','" + serino.Text + "','" + subeadi.Text + "','" + hesapno.Text + "')";


                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        komutsatir.Connection = con;
                        komutsatir.ExecuteNonQuery();
                        con.Close();
                        listele();
                        


                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            
        }

        private void alinancek_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            // TODO: This line of code loads data into the 'onmuhasebeDataSet9.alinancek' table. You can move, or remove it, as needed.
            this.alinancekTableAdapter1.Fill(this.onmuhasebeDataSet9.alinancek);
            
           

        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from alinancek", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            

                string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15;

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
                col15 = dataGridView1[14, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...


                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "Update alinancek set bordrono='" + Convert.ToString(col1) + "', tarih='" + Convert.ToString(col2) + "', saat='" + Convert.ToString(col3) + "', aciklama='" + Convert.ToString(col4) + "', cariadi='" + Convert.ToString(col5) + "', evrakdurumu='" + Convert.ToString(col6) + "', serino='" + Convert.ToString(col7) + "', vadetarihi='" + Convert.ToString(col8) + "', borclu='" + Convert.ToString(col9) + "', odemeyeri='" + Convert.ToString(col10) + "', tutar='" + Convert.ToString(col11) + "', parabirimi='" + Convert.ToString(col12) + "', bankaadi='" + Convert.ToString(col13) + "', subeadi='" + Convert.ToString(col14) + "', hesapno='" + Convert.ToString(col15) + "' where bordrono='" + textBox1.Text + "'";


                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    komutsatir.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    con.Close();
                    listele();
                    


                }

                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }




               
                if (col10 == "KASA")
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();


                        string komut2 = "insert into cekhareket(bordrono,islemtarihi,islemturu,cariadi,evrakdurumu,serino,vade,borc,alacak,odemeyeri,parabirimi,bankaadi,subeadi,hesapno) values('" + bordrono.Text + "','" + tarih.Text + "','" + "ÇEK GİRİŞ" + "','" + cariadi.Text + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + vadetarihi.Text + "','" + Convert.ToString(col11) + "','" + "0" + "','" + Convert.ToString(col10) + "','" + Convert.ToString(col12) + "','" + Convert.ToString(col13) + "','" + Convert.ToString(col14) + "','" + Convert.ToString(col15) + "')";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - ALINAN ÇEK" + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col4) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col11) + "','" + "0" + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + Convert.ToString(col8) + "','" + Convert.ToString(col5) + "','" + Convert.ToString(col10) + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ - ALINAN ÇEK" + "','" + Convert.ToString(col1) + "','" + "MERKEZ KASA" + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col4) + "','" + Convert.ToString(col5) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col11) + "','" + "0" + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "')";

                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                        OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                        komutsatir2.Connection = con;
                        komutsatir3.Connection = con;
                        komutsatir4.Connection = con;

                        komutsatir2.ExecuteNonQuery();
                        komutsatir3.ExecuteNonQuery();
                        komutsatir4.ExecuteNonQuery();
                        con.Close();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");


                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else if (col10 == "BANKA")
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();


                        string komut2 = "insert into cekhareket(bordrono,islemtarihi,islemturu,cariadi,evrakdurumu,serino,vade,borc,alacak,odemeyeri,parabirimi,bankaadi,subeadi,hesapno) values('" + bordrono.Text + "','" + tarih.Text + "','" + "ÇEK GİRİŞ" + "','" + cariadi.Text + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + vadetarihi.Text + "','" + Convert.ToString(col11) + "','" + "0" + "','" + Convert.ToString(col10) + "','" + Convert.ToString(col12) + "','" + Convert.ToString(col13) + "','" + Convert.ToString(col14) + "','" + Convert.ToString(col15) + "')";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "BANKA ÇIKIŞ - ALINAN ÇEK" + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col4) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col11) + "','" + "0" + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + Convert.ToString(col8) + "','" + "" + "','" + Convert.ToString(col10) + "')";
                        string komut4 = "insert into bankahareket(cariadi,islemtarihi,islemturu,bankaadi,subeadi,hesapno,bakiye,dekontno,girentutar,cikantutar,parabirimi,aciklama) values('" + Convert.ToString(col5) + "','" + Convert.ToString(col2) + "','" + "BANKA ÇIKIŞ - ALINAN ÇEK" + "','" + Convert.ToString(col13) + "','" + Convert.ToString(col14) + "','" + Convert.ToString(col15) + "','" + "0" + "','" + Convert.ToString(col1) + "','" + "0" + "','" + Convert.ToString(col11) + "','" + Convert.ToString(col12) + "','" + Convert.ToString(col4) + "')";

                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                        OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                        komutsatir2.Connection = con;
                        komutsatir3.Connection = con;
                        komutsatir4.Connection = con;

                        komutsatir2.ExecuteNonQuery();
                        komutsatir3.ExecuteNonQuery();
                        komutsatir4.ExecuteNonQuery();
                        con.Close();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");


                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            cekbol a = new cekbol();

            a.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenibankahesabi a = new yenibankahesabi();
            a.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15;

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
            col15 = dataGridView1[14, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            


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
            float x = 160.0F;
            float y = 140.0F;
            float width = 140.0F;
            float height = 200.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);
            float a = 50.0F;
            float b = 140.0F;
            float widt = 750.0F;
            float heigh = 200.0F;
            RectangleF drawRect2 = new RectangleF(a, b, widt, heigh);
            float c = 50.0F;
            float d = 140.0F;
            float wid = 110.0F;
            float heig = 200.0F;
            RectangleF drawRect3 = new RectangleF(c, d, wid, heig);
            float f = 300.0F;
            float g = 140.0F;
            float wi = 140.0F;
            float hei = 200.0F;
            RectangleF drawRect4 = new RectangleF(f, g, wi, hei);
            float r = 440.0F;
            float l = 140.0F;
            float w = 140.0F;
            float he = 200.0F;
            RectangleF drawRect5 = new RectangleF(r, l, w, he);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
            Pen blackPen2 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen2, a, b, widt, heigh);
            Pen blackPen3 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen3, c, d, wid, heig);
            Pen blackPen4 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen4, f, g, wi, hei);
            Pen blackPen5 = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen5, r, l, w, he);

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

            String drawyazi = "Alınan Çek(01)";
            String drawyazi2 = "Tutar";
            String drawyazi3 = "Borçlu :" + col5;
            String drawyazi4 = "Açıklama : " + "" +  col4;
            String drawyazi5 = "";
            String drawyazi6 = "";
            String drawyazi7 = "Tarih";
            String drawyazi8 = "Cari Adı";
            String drawyazi9 = "Bordro No";
            String drawyazi10 = "Borçlu";
            String drawyazi11 = col2;
            String drawyazi12 = col5;
            String drawyazi13 = col1;
            String drawyazi14 = col11;
            String drawyazi15 = "TOPLAM";
            String drawyazi16 = "";
            String drawyazi17 = "";
            String drawyazi18 = "";
            String drawyazi19 = col11 + " TL";
            String drawyazi20 = "";
            String drawyazi21 = "";
            String drawyazi22 = "";
            String drawyazi23 = col5;


            // Create font and brush.
            Font drawFon = new Font("Arial", 12);
            SolidBrush drawfirca = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(80.0F, 50.0F);
            PointF drawPoint2 = new PointF(650.0F, 120.0F);
            PointF drawPoint3 = new PointF(315.0F, 50.0F);
            PointF drawPoint4 = new PointF(80.0F, 450.0F);
            PointF drawPoint5 = new PointF(590.0F, 210.0F);
            PointF drawPoint6 = new PointF(590.0F, 120.0F);
            PointF drawPoint7 = new PointF(100.0F, 120.0F);
            PointF drawPoint8 = new PointF(250.0F, 120.0F);
            PointF drawPoint9 = new PointF(400.0F, 120.0F);
            PointF drawPoint10 = new PointF(550.0F, 120.0F);
            PointF drawPoint11 = new PointF(100.0F, 160.0F);
            PointF drawPoint12 = new PointF(250.0F, 160.0F);
            PointF drawPoint13 = new PointF(400.0F, 160.0F);
            PointF drawPoint14 = new PointF(670.0F, 160.0F);
            PointF drawPoint15 = new PointF(480.0F, 350.0F);
            PointF drawPoint16 = new PointF(80.0F, 485.0F);
            PointF drawPoint17 = new PointF(480.0F, 430.0F);
            PointF drawPoint18 = new PointF(480.0F, 470.0F);
            PointF drawPoint19 = new PointF(650.0F, 350.0F);
            PointF drawPoint20 = new PointF(700.0F, 390.0F);
            PointF drawPoint21 = new PointF(700.0F, 430.0F);
            PointF drawPoint22 = new PointF(700.0F, 470.0F);
            PointF drawPoint23 = new PointF(520.0F, 160.0F);


            // Draw string to screen.
            /*e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);*/
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
            e.Graphics.DrawString(drawyazi23, drawFon, drawBrush, drawPoint23, drawFormat2);

        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            cektahsilatibanka a = new cektahsilatibanka();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "alinancek";
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

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            cekciro a = new cekciro();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankahesap a = new bankahesap();
            a.label7.Text = "alinancek";
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
                    OleDbCommand komut = new OleDbCommand("delete from alinancek where bordrono='" + textBox1.Text + "'");
                    OleDbCommand komut2 = new OleDbCommand("delete from cekhareket where bordrono='" + textBox1.Text + "'");
                    komut.Connection = baglan;
                    komut2.Connection = baglan;
                    komut.ExecuteNonQuery();
                    komut2.ExecuteNonQuery();
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