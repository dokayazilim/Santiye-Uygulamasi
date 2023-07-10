using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registry.CurrentUser.CreateSubKey("DOKA").SetValue("lisans", lisanskodu.Text);
            button3.Enabled = true;
            button1.Enabled = false;
            MessageBox.Show("Lisans işlemi başarılı. Teşekkür ederiz.", "Lisans İşlemi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanicigiris a = new kullanicigiris();
            a.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey("DOKA").GetValue("lisans") != null)
            {
                button1.Enabled = false;
                button3.Enabled = true;
                lisanskodu.Enabled = false;
                musterino.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen lisans kodunu tekrar kontrol ediniz.", "Uyarı");
                button1.Enabled = true;
                button3.Enabled = false;
                lisanskodu.Enabled = true;
                musterino.Enabled = true;
            }

        }
    }
}
