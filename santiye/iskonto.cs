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
    public partial class iskonto : Form
    {
        public iskonto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (islemturu.Text == "Yüzde")
            {
                double isk = Convert.ToDouble(isko.Text);
                double ttr = Convert.ToDouble(tutar.Text);

                double isktopla = isk;
                double iskbolum = (100 - isktopla) / 100;
                double isksonuc = ttr * iskbolum;
                sonuc.Text = isksonuc.ToString();
            }
            else if (islemturu.Text == "Tutar")
            {
                double isk = Convert.ToDouble(isko.Text);
                double ttr = Convert.ToDouble(tutar.Text);

                double isktopla = isk;
                double iskbolum = (isk/ttr) * 100;
                double isksonuc = 100 - iskbolum;
                sonuc.Text = isksonuc.ToString();
            }
        }
    }
}
