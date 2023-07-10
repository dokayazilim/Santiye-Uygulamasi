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
    public partial class cektahsilatibanka : Form
    {
        public cektahsilatibanka()
        {
            InitializeComponent();
        }

        private void cektahsilatibanka_Load(object sender, EventArgs e)
        {
            label15.Visible = false;
            // TODO: This line of code loads data into the 'onmuhasebeDataSet31.cektahsilat' table. You can move, or remove it, as needed.
            this.cektahsilatTableAdapter1.Fill(this.onmuhasebeDataSet31.cektahsilat);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cekturu.Text == "ÇEK GİRİŞ")
            {
                cekhareket a = new cekhareket();
                a.label7.Text = "cektahsil";
                a.filtrele.Text = "ÇEK GİRİŞ";
                a.Show();

            }
            else if (cekturu.Text == "ÇEK ÇIKIŞ")
            {
                cekhareket a = new cekhareket();
                a.label7.Text = "cektahsilcikis";
                a.filtrele.Text = "ÇEK ÇIKIŞ";
                a.Show();

            }
            else
            {
                MessageBox.Show("Lütfen 'Çek Türü' seçiniz.", "Uyarı");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string trh = "-";
                if (cekturu.Text == "ÇEK GİRİŞ")
                {
                    evrakdurumu.Text = "Tahsil Edildi";

                    double baki = Convert.ToDouble(bakiye.Text);
                    double ttr = Convert.ToDouble(tutar.Text);
                    double sonuc = baki - ttr;

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "INSERT INTO cektahsilat(cekturu,cekhesabi,bankaadi,hesapno,subeadi,evrakdurumu,odemeyeri,islemtarihi,tutar,parabirimi,aciklama)VALUES('" + cekturu.Text + "','" + cekhesabi.Text + "','" + bankaadi.Text + "','" + hesapno.Text + "','" + subeadi.Text + "','" + evrakdurumu.Text + "','" + odemeyeri.Text + "','" + islemtarihi.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + aciklama.Text + "')";
                        string komut2 = "delete from alinancek where bordrono='"+label15.Text+"'";
                        string komut3 = "update cekhareket set borc='" + sonuc + "',evrakdurumu='" + evrakdurumu.Text + "',vade='"+trh+"' where islemturu='" + cekturu.Text + "'";
                        
                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        komutsatir3.Connection = con;
                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        komutsatir3.ExecuteNonQuery();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                    }

                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());


                    }
                }
                else if (cekturu.Text == "ÇEK ÇIKIŞ")
                {
                    evrakdurumu.Text = "Tahsil Edildi";

                    double baki = Convert.ToDouble(bakiye.Text);
                    double ttr = Convert.ToDouble(tutar.Text);
                    double sonuc = baki - ttr;

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "INSERT INTO cektahsilat(cekturu,cekhesabi,bankaadi,hesapno,subeadi,evrakdurumu,odemeyeri,islemtarihi,tutar,parabirimi,aciklama)VALUES('" + cekturu.Text + "','" + cekhesabi.Text + "','" + bankaadi.Text + "','" + hesapno.Text + "','" + subeadi.Text + "','" + evrakdurumu.Text + "','" + odemeyeri.Text + "','" + islemtarihi.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + aciklama.Text + "')";
                        string komut2 = "delete from verilencek where bordrono='" + label15.Text + "'";
                        string komut3 = "update cekhareket set borc='" + sonuc + "',evrakdurumu='" + evrakdurumu.Text + "' where islemturu='" + cekturu.Text + "'";
                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        komutsatir3.Connection = con;
                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        komutsatir3.ExecuteNonQuery();
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
                    MessageBox.Show("Lütfen 'Çek Türü' seçiniz.", "Uyarı");
                }
            
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from cektahsilat", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void kaydeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cekturu.Text == "ÇEK GİRİŞ")
            {
                evrakdurumu.Text = "Tahsil Edildi";

                double baki = Convert.ToDouble(bakiye.Text);
                double ttr = Convert.ToDouble(tutar.Text);
                double sonuc = baki - ttr;

                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "INSERT INTO cektahsilat(cekturu,cekhesabi,bankaadi,hesapno,subeadi,evrakdurumu,odemeyeri,islemtarihi,tutar,parabirimi,aciklama)VALUES('" + cekturu.Text + "','" + cekhesabi.Text + "','" + bankaadi.Text + "','" + hesapno.Text + "','" + subeadi.Text + "','" + evrakdurumu.Text + "','" + odemeyeri.Text + "','" + islemtarihi.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + aciklama.Text + "')";
                    string komut2 = "update alinancek set tutar='" + sonuc + "',evrakdurumu='" + evrakdurumu.Text + "' where cariadi='" + cekhesabi.Text + "'";
                    string komut3 = "update cekhareket set borc='" + sonuc + "',evrakdurumu='" + evrakdurumu.Text + "' where islemturu='" + cekturu.Text + "'";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();
                    listele();
                    MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            }
            else if (cekturu.Text == "ÇEK ÇIKIŞ")
            {
                evrakdurumu.Text = "Tahsil Edildi";

                double baki = Convert.ToDouble(bakiye.Text);
                double ttr = Convert.ToDouble(tutar.Text);
                double sonuc = baki - ttr;

                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "INSERT INTO cektahsilat(cekturu,cekhesabi,bankaadi,hesapno,subeadi,evrakdurumu,odemeyeri,islemtarihi,tutar,parabirimi,aciklama)VALUES('" + cekturu.Text + "','" + cekhesabi.Text + "','" + bankaadi.Text + "','" + hesapno.Text + "','" + subeadi.Text + "','" + evrakdurumu.Text + "','" + odemeyeri.Text + "','" + islemtarihi.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + aciklama.Text + "')";
                    string komut2 = "update verilencek set tutar='" + sonuc + "',evrakdurumu='" + evrakdurumu.Text + "' where cariadi='" + cekhesabi.Text + "'";
                    string komut3 = "update cekhareket set borc='" + sonuc + "',evrakdurumu='" + evrakdurumu.Text + "' where islemturu='" + cekturu.Text + "'";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();
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
                MessageBox.Show("Lütfen 'Çek Türü' seçiniz.", "Uyarı");
            }
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void aktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }
    }
}
