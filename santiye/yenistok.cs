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
    public partial class yenistok : Form
    {
        public yenistok()
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
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO stokkayit(stokkodu,stokadi,barkodu,alisfiyati,miktar,kdvorani,birimi,satisfiyati,kdvoranisatis,parabirimi,grupkodu,grupadi,ozelkodu,ozelkoduiki)VALUES('" + stokkodu.Text + "','" + stokadi.Text + "','" + barkodu.Text + "','" + alisfiyati.Text + "','" + miktar.Text + "','" + kdvoranialis.Text + "','" + birimi.Text + "','" + satisfiyati.Text + "','" + kdvoranisatis.Text + "','" + parabirimi.Text + "','" + grupkodu.Text + "','" + grupadi.Text + "','" + ozelkodu.Text + "','" + ozelkoduiki.Text + "')";

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

        private void button2_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            barkodu.Clear();
            alisfiyati.Clear();
            miktar.Text = "0,00";
            grupkodu.Clear();
            ozelkodu.Clear();
            kdvoranialis.SelectedIndex = -1;
            birimi.SelectedIndex = -1;
            satisfiyati.Clear();
            kdvoranisatis.SelectedIndex = -1;
            parabirimi.SelectedIndex = -1;
            grupadi.Clear();
            ozelkoduiki.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gruplar a = new gruplar();
            a.label8.Text = "stok";
            a.Show();
        }

        private void yedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }
    }
}
