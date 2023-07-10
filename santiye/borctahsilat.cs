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
    public partial class borctahsilat : Form
    {
        public borctahsilat()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void borctahsilat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet23.tahsilat' table. You can move, or remove it, as needed.
            this.tahsilatTableAdapter1.Fill(this.onmuhasebeDataSet23.tahsilat);
         

        }

        private void button4_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "borctahsil";
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

                if (islemturu.Text == "Borç")
                {
                    double baki = Convert.ToDouble(bakiye.Text);
                    double ttr = Convert.ToDouble(tutar.Text);
                    double sonuc = baki - ttr;

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "INSERT INTO tahsilat(cariadi,bakiye,evrakno,islemtarihi,tutar,parabirimi,aciklama,islemturu)VALUES('" + cariadi.Text + "','" + bakiye.Text + "','" + evrakno.Text + "','" + islemtarihi.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + aciklama.Text + "','" + islemturu.Text + "')";
                        string komut2 = "update carikart set bakiye='" + sonuc + "'where adisoyadi='" + cariadi.Text + "'";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ - BORÇ TAHSİLATI" + "','" + evrakno.Text + "','" + islemtarihi.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + "MERKEZ" + "')";
                        string komut4 = "update kasakarti set alacak='" + tutar.Text + "' where kasaadi='" + evrakno.Text + "'";
                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                        OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        komutsatir3.Connection = con;
                        komutsatir4.Connection = con;
                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        komutsatir3.ExecuteNonQuery();
                        komutsatir4.ExecuteNonQuery();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                    }

                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());


                    }
                }

                else if (islemturu.Text == "Alacak")
                {
                    double baki = Convert.ToDouble(bakiye.Text);
                    double ttr = Convert.ToDouble(tutar.Text);
                    double sonuc = baki - ttr;

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "INSERT INTO tahsilat(cariadi,bakiye,evrakno,islemtarihi,tutar,parabirimi,aciklama,islemturu)VALUES('" + cariadi.Text + "','" + bakiye.Text + "','" + evrakno.Text + "','" + islemtarihi.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + aciklama.Text + "','" + islemturu.Text + "')";
                        string komut2 = "update carikart set bakiye='" + sonuc + "'where adisoyadi='" + cariadi.Text + "'";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - ALACAK TAHSİLATI" + "','" + evrakno.Text + "','" + islemtarihi.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + "MERKEZ" + "')";
                        string komut4 = "update kasakarti set borc='" + tutar.Text + "' where kasaadi='" + evrakno.Text + "'";
                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                        OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        komutsatir3.Connection = con;
                        komutsatir4.Connection = con;
                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        komutsatir3.ExecuteNonQuery();
                        komutsatir4.ExecuteNonQuery();
                        listele();
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
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from tahsilat", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            kasakarti a = new kasakarti();
            a.label7.Text = "tahsil";
            a.Show();
        }
    }
}
