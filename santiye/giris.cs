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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lisanskodu.Text != "demo")
            {
                MessageBox.Show("Lisans Kodu boş geçilemez! Demo için 'demo' yazınız!", "Uyarı");
            }
            else if (musterino.Text != "demo")
            {
                MessageBox.Show("Müşteri No boş geçilemez! Demo için 'demo' yazınız!", "Uyarı");
            }
            else
            {
                kullanicigiris a = new kullanicigiris();
                a.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
