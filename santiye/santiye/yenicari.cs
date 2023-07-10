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
    public partial class yenicari : Form
    {
        public yenicari()
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

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO carikart(ozelkodu,adisoyadi,carikodu,donem,tckimlik,vergidairesi,vergino,il,ilce,semt,mahalle,cadde,sokak,aptadi,aptno,postakodu,telefon,fax,cep,durum,eposta,website,bakiye,parabirimi)VALUES('" + ozelkodu.Text + "','" + adisoyadi.Text + "','" + carikod.Text + "','" + donem.Text + "','" + tckimlikno.Text + "','" + vergidairesi.Text + "','" + vergino.Text + "','" + il.Text + "','" + ilce.Text + "','" + semt.Text + "','" + mahalle.Text + "','" + cadde.Text + "','" + sokak.Text + "','" + aptadi.Text + "','" + aptno.Text + "','" + postakodu.Text + "','" + telefon.Text + "','" + fax.Text + "','" + cep.Text + "','" + durumu.Text + "','" + eposta.Text + "','" + website.Text + "','" + bakiye.Text + "','" + parabirimi.Text + "')";

                
                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                
                komutsatir.Connection = con;
                

                komutsatir.ExecuteNonQuery();
                
                con.Close();
               
                MessageBox.Show("Başarıyla kaydedildi!", "Uyarı");


            }

            catch (OleDbException ex)
            {

                MessageBox.Show(ex.ToString());


            }

            
        }

        private void yedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ozelkodu.Clear();
            adisoyadi.Clear();
            tckimlikno.Clear();
            vergidairesi.Clear();
            vergino.Clear();
            il.Clear();
            ilce.Clear();
            semt.Clear();
            mahalle.Clear();
            cadde.Clear();
            sokak.Clear();
            aptadi.Clear();
            aptno.Clear();
            postakodu.Clear();
            telefon.Clear();
            fax.Clear();
            cep.Clear();
            website.Clear();
            eposta.Clear();
            durumu.SelectedIndex = -1;
            bakiye.Clear();
            carikod.Clear();
            
        }
    }
}
