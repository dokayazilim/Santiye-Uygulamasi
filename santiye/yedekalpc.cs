using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace santiye
{
    public partial class yedekalpc : Form
    {
        public yedekalpc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string klasorYeri = "D:\\";//Klasör yerini belirtiyoruz.
                string klasorAdi = "Ön Muhasebe Smart";//Klasör adını belirtiyoruz.
                string klasorolustur = klasorYeri + @"\" + klasorAdi;
                Directory.CreateDirectory(klasorolustur);//yedek veritabanının yerini oluşturuyor.
                System.IO.File.Copy("onmuhasebe.accdb", "D:\\Ön Muhasebe Smart\\" + textBox1.Text + ".accdb");
                MessageBox.Show("Veritabanı ( D: Ön Muhasebe Smart ) klasörüne kaydedilmiştir!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch
            {
                MessageBox.Show("Veritabanı aynı isimle kaydedilemez! Lütfen farklı bir isim koymayı deneyiniz!", "Uyarı");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
