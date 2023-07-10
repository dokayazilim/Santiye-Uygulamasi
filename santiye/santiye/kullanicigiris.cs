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
            if ((admin.Text != "ab12cd") && (admin.Text != "dk34dk") && (admin.Text != "admin") && (admin.Text != "admin1"))
            {
                MessageBox.Show("Kullanıcı adı yanlış veya eksik girildi! Lütfen tekrar kontrol ediniz!", "Uyarı");
            }
            else if ((sifre.Text != "12345") && (sifre.Text != "ab123dc") && (sifre.Text != "abc12cba") && (sifre.Text != "bs111a1"))
            {
                MessageBox.Show("Şifre yanlış veya eksik girildi! Lütfen tekrar kontrol ediniz!", "Uyarı");
            }
            else if ((gk.Text != "AB55YT") && (gk.Text != "CBS77AT") && (gk.Text != "SMD2234") && (gk.Text != "AV56MM"))
            {
                MessageBox.Show("Güvenlik Kodu yanlış veya eksik girildi! Lütfen tekrar kontrol ediniz!", "Uyarı");
            }
            else
            {
               

                anamenu a = new anamenu();
                a.Show();
                this.Hide();

            }
        }
    }
}
