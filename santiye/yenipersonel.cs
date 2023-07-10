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
    public partial class yenipersonel : Form
    {
        public yenipersonel()
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

        private void button1_Click(object sender, EventArgs e)
        {
            double maas = Convert.ToDouble(maasi.Text);
            double avns = Convert.ToDouble(asgarimaasi.Text);
            double sonuc = maas - avns;
            netmaasi.Text = sonuc.ToString();
            
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO personel(adisoyadi,gorevi,telbir,teliki,adres,tckimlik,sgkno,giristarihi,personelgrubu,maasi,avans,netmaas,parabirimi,islemtarihi,aciklama,resimadi,resimadres,resimid)VALUES('" + adisoyadi.Text + "','" + gorevi.Text + "','" + tel.Text + "','" + tel2.Text + "','" + adres.Text + "','" + tckimlikno.Text + "','" + sgkno.Text + "','" + giristarihi.Text + "','" + personelgrubu.Text + "','" + maasi.Text + "','" + asgarimaasi.Text + "','" + netmaasi.Text + "','" + parabirimi.Text + "','" + islemtarihi.Text + "','" + aciklama.Text + "','" + "" + "','" + "" + "','" + "" + "')";
                string komut2 = "INSERT INTO personelhareket(adisoyadi,islemtarihi,islemturu,odemeyeri,giren,cikan,parabirimi,aciklama,grubu) values('" + adisoyadi.Text + "','" + islemtarihi.Text + "','" + "PERSONEL KAYIT" + "','" + "KASA" + "','" + netmaasi.Text + "','" + "0" + "','" + parabirimi.Text + "','" + aciklama.Text + "','" + personelgrubu.Text + "')";
                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                OleDbCommand komutsatir2 = new OleDbCommand(komut2,con);
                komutsatir.Connection = con;
                komutsatir2.Connection = con;
                komutsatir.ExecuteNonQuery();
                komutsatir2.ExecuteNonQuery();
                con.Close();

                


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


                string komut2 = "INSERT INTO gruphareket(grupadi,islemturu,islemtarihi,cariadi,aciklama,borc,alacak,bakiye) values('" + personelgrubu.Text + "','" + "PERSONEL KAYIT" + "','" + islemtarihi.Text + "','" + adisoyadi.Text + "','" + aciklama.Text + "','" + "0" + "','" + netmaasi.Text + "','" + "0" + "')";
                
                OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                
                komutsatir2.Connection = con;
                
                komutsatir2.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


            }

            catch (OleDbException ex)
            {

                MessageBox.Show(ex.ToString());


            }          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gruplar a = new gruplar();
            a.label8.Text = "personel";
            a.Show();
        }

        private void yedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }
    }
}
