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
    public partial class avansmaas : Form
    {
        public avansmaas()
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

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelkayit a = new personelkayit();
            a.label2.Text = "avansmaas";
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (borc.Checked)
            {
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ - PERSONEL AVANS" + "','" + "" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";
                    string komut2 = "INSERT INTO personelhareket(adisoyadi,islemtarihi,islemturu,odemeyeri,giren,cikan,parabirimi,aciklama,grubu) values('" + cariadi.Text + "','" + tarih.Text + "','" + "AVANS ÖDEMESİ" + "','" + "KASA" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + aciklama.Text + "','" + vergidairesi.Text + "')";
                    string komut3 = "INSERT INTO gelirgiderhareket(cariadi,islemtarihi,islemno,islemturu,tutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama) values('" + cariadi.Text + "','" + tarih.Text + "','" + "PERSONEL AVANS ÖDEMESİ" + "','" + "GİDER İŞLEMİ" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + aciklama.Text + "')";
                    /*string komut5 = "update grup set alacak='" + tutar.Text + "' where grupadi='" + evrakno.Text + "'";*/
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    /*OleDbCommand komutsatir4 = new OleDbCommand(komut5, con);*/
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    /*komutsatir4.Connection = con;*/
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();
                    /*komutsatir4.ExecuteNonQuery();*/
                    con.Close();

                    MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\gruplar.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "insert into gruphareket(grupadi,islemturu,islemtarihi,cariadi,aciklama,borc,alacak,bakiye) values('" + vergidairesi.Text + "','" + "PERSONEL AVANS ÖDEMESİ" + "','" + tarih.Text + "','" + cariadi.Text + "','" + aciklama.Text + "','" + "0" + "','" + tutar.Text + "','" + "0" + "')";
                   
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    
                    komutsatir.Connection = con;
                    
                    komutsatir.ExecuteNonQuery();
                    
                    con.Close();

                    


                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            }
            else if (alacak.Checked)
            {
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ - PERSONEL MAAŞI" + "','" + "" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";
                    string komut2 = "INSERT INTO personelhareket(adisoyadi,islemtarihi,islemturu,odemeyeri,giren,cikan,parabirimi,aciklama,grubu) values('" + cariadi.Text + "','" + tarih.Text + "','" + "MAAŞ ÖDEMESİ" + "','" + "KASA" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + aciklama.Text + "','" + vergidairesi.Text + "')";
                    string komut3 = "INSERT INTO gelirgiderhareket(cariadi,islemtarihi,islemno,islemturu,tutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama) values('" + cariadi.Text + "','" + tarih.Text + "','" + "PERSONEL MAAŞ ÖDEMESİ" + "','" + "GİDER İŞLEMİ" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + aciklama.Text + "')";
                    /*string komut5 = "update grup set alacak='" + tutar.Text + "' where grupadi='" + evrakno.Text + "'";*/

                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    /*OleDbCommand komutsatir4 = new OleDbCommand(komut5, con);*/
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    /*komutsatir4.Connection = con;*/
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();
                    /*komutsatir4.ExecuteNonQuery();*/
                    con.Close();

                    MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\gruplar.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "insert into gruphareket(grupadi,islemturu,islemtarihi,cariadi,aciklama,borc,alacak,bakiye) values('" + vergidairesi.Text + "','" + "PERSONEL MAAŞ ÖDEMESİ" + "','" + tarih.Text + "','" + cariadi.Text + "','" + aciklama.Text + "','" + "0" + "','" + tutar.Text + "','" + "0" + "')";

                    OleDbCommand komutsatir = new OleDbCommand(komut, con);

                    komutsatir.Connection = con;

                    komutsatir.ExecuteNonQuery();

                    con.Close();




                }

                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gruplar a = new gruplar();
            a.label8.Text = "kasaavans";
            a.Show();
        }
    }
}
