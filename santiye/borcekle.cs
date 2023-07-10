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
    public partial class borcekle : Form
    {
        public borcekle()
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

        private void button1_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "borcekle";
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (borc.Checked)
            {
                double baki = Convert.ToDouble(vergino.Text);
                double ttr = Convert.ToDouble(tutar.Text);
                double sonuc = baki + ttr;
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "INSERT INTO carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri)VALUES('" + "BORÇ EKLEME" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + "KASA" + "')";
                    string komut2 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ - CARİ BORÇ EKLEME" + "','" + evrakno.Text + "','" + "MERKEZ KASA" + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";
                    string komut3 = "update carikart set bakiye='" + sonuc + "' where adisoyadi='" + cariadi.Text + "'";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();

                    MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            }
            else if (alacak.Checked)
            {
                double baki = Convert.ToDouble(vergino.Text);
                double ttr = Convert.ToDouble(tutar.Text);
                double sonuc = baki - ttr;
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "INSERT INTO carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri)VALUES('" + "BORÇ EKLEME" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + "KASA" + "')";
                    string komut2 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ - CARİ ALACAK EKLEME" + "','" + evrakno.Text + "','" + "MERKEZ KASA" + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" +"','" + parabirimi.Text + "','" + "PEŞİN" + "')";
                    string komut3 = "update carikart set bakiye='" + sonuc + "' where adisoyadi='" + cariadi.Text + "'";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();

                    MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            }
            else 
            {
                MessageBox.Show("Lütfen 'İşlem Türü' seçiniz!","Uyarı");
            }
        }

        private void borcekle_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            kasakarti a = new kasakarti();
            a.label7.Text = "borcekle";
            a.Show();
        }
    }
}
