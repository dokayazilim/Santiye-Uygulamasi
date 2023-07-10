using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace santiye
{
    public partial class zarf : Form
    {
        public zarf()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
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
            String drawyazi2 = "";
            String drawyazi3 = "";
            String drawyazi4 = "";
            String drawyazi5 = "";
            String drawyazi6 = "";
            String drawyazi7 = "DEMO A.Ş. ";
            String drawyazi8 = "ANKARA";
            String drawyazi9 = "111111111";
            String drawyazi10 = "";
            String drawyazi11 = "";
            String drawyazi12 = "";
            String drawyazi13 = "";
            String drawyazi14 = "Sayın :";
            String drawyazi15 = "DEMO LTD. ŞTİ.";
            String drawyazi16 = "KİLİS";
            String drawyazi17 = "2222222222";
            String drawyazi18 = "";
            String drawyazi19 = "";
            String drawyazi20 = "";
            String drawyazi21 = "";
            String drawyazi22 = "";
            String drawyazi23 = "";


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
            PointF drawPoint7 = new PointF(140.0F, 120.0F);
            PointF drawPoint8 = new PointF(140.0F, 150.0F);
            PointF drawPoint9 = new PointF(140.0F, 180.0F);
            PointF drawPoint10 = new PointF(150.0F, 250.0F);
            PointF drawPoint11 = new PointF(305.0F, 280.0F);
            PointF drawPoint12 = new PointF(390.0F, 320.0F);
            PointF drawPoint13 = new PointF(145.0F, 340.0F);
            PointF drawPoint14 = new PointF(670.0F, 380.0F);
            PointF drawPoint15 = new PointF(650.0F, 420.0F);
            PointF drawPoint16 = new PointF(650.0F, 450.0F);
            PointF drawPoint17 = new PointF(650.0F, 480.0F);
            PointF drawPoint18 = new PointF(650.0F, 510.0F);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Landscape = true;
        }
    }
}
