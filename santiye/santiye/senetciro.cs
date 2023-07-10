using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace santiye
{
    public partial class senetciro : Form
    {
        public senetciro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cekturu.Text == "Alınan Senet")
            {
                alinancek a = new alinancek();

                a.Show();
            }
            else if (cekturu.Text == "Verilen Senet")
            {
                verilencek a = new verilencek();

                a.Show();
            }
        }

        private void senetciro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet52.senetciro' table. You can move, or remove it, as needed.
            this.senetciroTableAdapter1.Fill(this.onmuhasebeDataSet52.senetciro);
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            evrakdurumu.Text = "Ciro Edildi";
            string trh = "-";

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO senetciro(cekturu,cekhesabi,bankaadi,hesapno,subeadi,evrakdurumu,cekhesabidiger,bankaadidiger,hesapnodiger,subeadidiger,evrakdurumudiger,aciklama,odemeyeri,tutar,parabirimi)VALUES('" + cekturu.Text + "','" + cekhesabi.Text + "','" + bankaadi.Text + "','" + hesapno.Text + "','" + subeadi.Text + "','" + tarih.Text + " - " + saat.Text + "','" + cekhesabidiger.Text + "','" + odemeyeri.Text + "','" + vadetarihi.Text + "','" + serino.Text + "','" + bordrono.Text + "','" + aciklama.Text + "','" + odemeyeri.Text + "','" + tutar.Text + "','" + parabirimi.Text + "')";
                string komut2 = "insert into verilensenet(bordrono,tarih,saat,aciklama,cariadi,evrakdurumu,serino,vadetarihi,borclu,odemeyeri,tutar,parabirimi,bankaadi,subeadi,hesapno) values ('" + bordrono.Text + "','" + tarih.Text + "','" + saat.Text + "','" + aciklama.Text + "','" + cekhesabidiger.Text + "','" + evrakdurumu.Text + "','" + serino.Text + "','" + vadetarihi.Text + "','" + cekhesabidiger.Text + "','" + odemeyeri.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + bankaadi.Text + "','" + subeadi.Text + "','" + hesapno.Text + "')";
                string komut3 = "update alinansenet set evrakdurumu='" + evrakdurumu.Text + "', borclu='" + cekhesabidiger.Text + "',vadetarihi='" + trh + "' where bordrono='" + bordrono.Text + "'";
                //string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "VERİLEN SENET" + "','" + bordrono.Text + "','" + "MERKEZ KASA" + "','" + tarih.Text + "','" + aciklama.Text + "','" + cekhesabi.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";
                string komut5 = "update senethareket set evrakdurumu='" + evrakdurumu.Text + "',vade='" + trh + "' where bordrono='" + bordrono.Text + "'";
                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                //OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                OleDbCommand komutsatir5 = new OleDbCommand(komut5, con);
                komutsatir.Connection = con;
                komutsatir2.Connection = con;
                komutsatir3.Connection = con;
                //komutsatir4.Connection = con;
                komutsatir.ExecuteNonQuery();
                komutsatir2.ExecuteNonQuery();
                komutsatir3.ExecuteNonQuery();
                //komutsatir4.ExecuteNonQuery();
                komutsatir5.ExecuteNonQuery();
                con.Close();
                listele();
                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");



            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from senetciro", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cekturu.Text == "SENET GİRİŞ")
            {
                senethareket a = new senethareket();
                a.label7.Text = "senetgirisdiger";
                a.filtrele.Text = "SENET GİRİŞ";
                a.Show();
            }
            else if (cekturu.Text == "SENET ÇIKIŞ")
            {
                senethareket a = new senethareket();
                a.label7.Text = "senetcikisdiger";
                a.filtrele.Text = "SENET ÇIKIŞ";
                a.Show();
            }
            else
            {
                MessageBox.Show("Lütfen 'Senet Türü' seçiniz!", "Uyarı");
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

        private void aktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (cekturu.Text == "SENET GİRİŞ")
            {
                senethareket a = new senethareket();
                a.label7.Text = "senetgiris";
                a.filtrele.Text = "SENET GİRİŞ";
                a.Show();
            }
            else if (cekturu.Text == "SENET ÇIKIŞ")
            {
                senethareket a = new senethareket();
                a.label7.Text = "senetcikis";
                a.filtrele.Text = "SENET ÇIKIŞ";
                a.Show();
            }
            else
            {
                MessageBox.Show("Lütfen 'Senet Türü' seçiniz!", "Uyarı");
            }
        }
    }
}
