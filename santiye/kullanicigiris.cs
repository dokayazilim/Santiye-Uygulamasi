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
    public partial class kullanicigiris : Form
    {
        public kullanicigiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin.Text != "demo")
            {
                MessageBox.Show("Kullanıcı adı yanlış veya eksik girildi! Lütfen tekrar kontrol ediniz!", "Uyarı");
            }
            else if (sifre.Text != "demo")
            {
                MessageBox.Show("Şifre yanlış veya eksik girildi! Lütfen tekrar kontrol ediniz!", "Uyarı");
            }
            else
            {
                MessageBox.Show("Lütfen bizlere Eksiklerimizi, Yanlışlarımızı, Hatalarımızı bildiriniz. Aksi takdirde programı satın almağa karar verdiğinizde yarım bir program almış olmayınız. Teşekkür ederiz.","Lütfen Dikkat");
                MessageBox.Show("Deneme sürümünden otomatik olarak Cari Hesaplar ve Banka Hesapları Demo ve Demo A.Ş. olarak tanımlanmış olup bakiyeleri de otomatik girilmiştir.","Uyarı");

                anamenu a = new anamenu();
                a.Show();
                this.Hide();

            }
        }
    }
}
