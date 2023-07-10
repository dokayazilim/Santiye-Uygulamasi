using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace santiye
{
    public partial class yenibankahesabi : Form
    {
        public yenibankahesabi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO bankahesap(cariadi,islemtarihi,bankaadi,subeadi,hesapno,aciklama,bakiye,parabirimi,iban)VALUES('" + cariadi.Text + "','" + islemtarihi.Text + "','" + bankaadi.Text + "','" + subeadi.Text + "','" + hesapno.Text + "','" + aciklama.Text + "','" + bakiye.Text + "','" + parabirimi.Text + "','" + dekontno.Text + "')";
                
                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


            }

            catch (OleDbException ex)
            {

                MessageBox.Show(ex.ToString());


            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cariadi.Clear();
            bankaadi.Clear();
            subeadi.Clear();
            aciklama.Clear();
            hesapno.Clear();
            bakiye.Clear();
            parabirimi.Text = "TL";
            dekontno.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "yenibankahesap";
            a.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bankakarti a = new bankakarti();
            a.label6.Text = "bankahesap";
            a.Show();
        }

        private void yedekALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO bankahesap(cariadi,islemtarihi,bankaadi,subeadi,hesapno,aciklama,bakiye,parabirimi,iban)VALUES('" + cariadi.Text + "','" + islemtarihi.Text + "','" + bankaadi.Text + "','" + subeadi.Text + "','" + hesapno.Text + "','" + aciklama.Text + "','" + bakiye.Text + "','" + parabirimi.Text + "','" + dekontno.Text + "')";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


            }

            catch (OleDbException ex)
            {

                MessageBox.Show(ex.ToString());


            }          
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariadi.Clear();
            bankaadi.Clear();
            subeadi.Clear();
            aciklama.Clear();
            hesapno.Clear();
            bakiye.Clear();
            parabirimi.Text = "TL";
            dekontno.Clear();
        }
    }
}
