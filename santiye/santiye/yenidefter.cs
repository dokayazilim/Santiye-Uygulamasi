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
    public partial class yenidefter : Form
    {
        public yenidefter()
        {
            InitializeComponent();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void yenidefter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet62.gider' table. You can move, or remove it, as needed.
            this.giderTableAdapter1.Fill(this.onmuhasebeDataSet62.gider);
            // TODO: This line of code loads data into the 'onmuhasebeDataSet61.gelir' table. You can move, or remove it, as needed.
            this.gelirTableAdapter1.Fill(this.onmuhasebeDataSet61.gelir);
            label13.Visible = false;
            label14.Visible = false;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                if (islemno.Text == "")
                {
                    MessageBox.Show("'İşlem No' alanı boş geçilemez.", "Uyarı");
                }
                else
                {
                    if (kdv.Text == "")
                    {
                        kdv.Text = "";
                    }
                    else
                    {
                        float kdvoran = float.Parse(kdv.Text);
                        double fiyat = Convert.ToDouble(tutar.Text);
                        double kdvislem = fiyat * (1 + (kdvoran / 100));
                        double kdvsonuc = (fiyat * kdvoran) / 100;
                        tutar.Text = kdvislem.ToString();
                        label13.Text = kdvsonuc.ToString();

                    }

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "INSERT INTO gelir(cariadi,islemtarihi,islemno,tutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama)VALUES('" + cariadi.Text + "','" + islemtarihi.Text + "','" + islemno.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + kdv.Text + "','" + label13.Text + "','" + tutar.Text + "','" + aciklama.Text + "')";
                        string komut2 = "INSERT INTO gelirgiderhareket(cariadi,islemtarihi,islemno,islemturu,gelirtutar,gidertutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama) values ('" + cariadi.Text + "','" + islemtarihi.Text + "','" + islemno.Text + "','" + "GELİR İŞLEMİ" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + kdv.Text + "','" + label13.Text + "','" + tutar.Text + "','" + aciklama.Text + "')";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ - GELİR İŞLEMİ" + "','" + islemno.Text + "','" + islemtarihi.Text + "','" + "" + "','" + label13.Text + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + "KASA" + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ - GELİR İŞLEMİ" + "','" + islemno.Text + "','" + "MERKEZ KASA" + "','" + islemtarihi.Text + "','" + "" + "','" + cariadi.Text + "','" + label13.Text + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";
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


                        
                        con.Close();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");


                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from gelir", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
                if (islemnogider.Text == "")
                {
                    MessageBox.Show("'İşlem No' alanı boş geçilemez.", "Uyarı");
                }
                else
                {

                    if (kdvgider.Text == "")
                    {
                        kdvgider.Text = "";
                    }
                    else
                    {
                        float kdvoran = float.Parse(kdvgider.Text);
                        double fiyat = Convert.ToDouble(tutargider.Text);
                        double kdvislem = fiyat * (1 + (kdvoran / 100));
                        double kdvsonuc = (fiyat * kdvoran) / 100;
                        tutargider.Text = kdvislem.ToString();
                        label14.Text = kdvsonuc.ToString();

                    }

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "INSERT INTO gider(cariadi,islemtarihi,islemno,tutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama)VALUES('" + cariadidiger.Text + "','" + islemtarihigider.Text + "','" + islemnogider.Text + "','" + tutargider.Text + "','" + parabirimigider.Text + "','" + kdvgider.Text + "','" + label14.Text + "','" + tutargider.Text + "','" + aciklamagider.Text + "')";
                        string komut2 = "INSERT INTO gelirgiderhareket(cariadi,islemtarihi,islemno,islemturu,gelirtutar,gidertutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama) values ('" + cariadidiger.Text + "','" + islemtarihigider.Text + "','" + islemnogider.Text + "','" + "GİDER İŞLEMİ" + "','" + "0" + "','" + tutargider.Text + "','" + parabirimigider.Text + "','" + kdvgider.Text + "','" + label14.Text + "','" + tutargider.Text + "','" + aciklamagider.Text + "')";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - GİDER İŞLEMİ" + "','" + islemnogider.Text + "','" + islemtarihigider.Text + "','" + "" + "','" + "0" + "','" + label14.Text + "','" + "0" + "','" + tutargider.Text + "','" + parabirimigider.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadidiger.Text + "','" + "KASA" + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ - GİDER İŞLEMİ" + "','" + islemnogider.Text + "','" + "MERKEZ KASA" + "','" + islemtarihigider.Text + "','" + "" + "','" + cariadidiger.Text + "','" + "0" + "','" + label14.Text + "','" + "0" + "','" + tutargider.Text + "','" + parabirimigider.Text + "','" + "PEŞİN" + "')";
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
                        con.Close();
                        listele2();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");


                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            
        }
        public void listele2()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from gider", con);
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            cariadi.Clear();
            islemno.Clear();
            tutar.Clear();
            parabirimi.SelectedIndex = -1;
            kdv.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cariadi.Clear();
            islemno.Clear();
            tutar.Clear();
            parabirimi.SelectedIndex = -1;
            kdv.SelectedIndex = -1;
        }

        private void gelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kdv.Text == "")
            {
                kdv.Text = "";
            }
            else
            {
                float kdvoran = float.Parse(kdv.Text);
                double fiyat = Convert.ToDouble(tutar.Text);
                double kdvislem = fiyat * (1 + (kdvoran / 100));
                double kdvsonuc = (fiyat * kdvoran) / 100;
                tutar.Text = kdvislem.ToString();
                label13.Text = kdvsonuc.ToString();

            }

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO gelir(cariadi,islemtarihi,islemno,tutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama)VALUES('" + cariadi.Text + "','" + islemtarihi.Text + "','" + islemno.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + kdv.Text + "','" + label13.Text + "','" + tutar.Text + "','" + "" + "')";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
                listele();
                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


            }

            catch (OleDbException ex)
            {

                MessageBox.Show(ex.ToString());


            }          
        }

        private void giderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kdvgider.Text == "")
            {
                kdvgider.Text = "";
            }
            else
            {
                float kdvoran = float.Parse(kdvgider.Text);
                double fiyat = Convert.ToDouble(tutargider.Text);
                double kdvislem = fiyat * (1 + (kdvoran / 100));
                double kdvsonuc = (fiyat * kdvoran) / 100;
                tutargider.Text = kdvislem.ToString();
                label14.Text = kdvsonuc.ToString();

            }

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO gider(cariadi,islemtarihi,islemno,tutar,parabirimi,kdv,kdvsiztutar,kdvlitutar,aciklama)VALUES('" + cariadidiger.Text + "','" + islemtarihigider.Text + "','" + islemnogider.Text + "','" + tutargider.Text + "','" + parabirimigider.Text + "','" + kdvgider.Text + "','" + label14.Text + "','" + tutargider.Text + "','" + "" + "')";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
                listele2();
                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


            }

            catch (OleDbException ex)
            {

                MessageBox.Show(ex.ToString());


            }          
        }

        private void gelirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cariadi.Clear();
            islemno.Clear();
            tutar.Clear();
            parabirimi.SelectedIndex = -1;
            kdv.SelectedIndex = -1;
        }

        private void giderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cariadi.Clear();
            islemno.Clear();
            tutar.Clear();
            parabirimi.SelectedIndex = -1;
            kdv.SelectedIndex = -1;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "gelir";
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "gider";
            a.Show();
        }

        private void aktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }
    }
}
