using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace santiye
{
    public partial class kasacikis : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public kasacikis()
        {
            InitializeComponent();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tasksItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void kasacikis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet37.kasacikis' table. You can move, or remove it, as needed.
            this.kasacikisTableAdapter1.Fill(this.onmuhasebeDataSet37.kasacikis);
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "INSERT INTO kasacikis(cariadi,tarih,aciklama,tutar,parabirimi,evrakno,kasaadi)VALUES('" + cariadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + evrakno.Text + "','" + kasaadi.Text + "')";

                    string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + kasaadi.Text + "')";
                    string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ" + "','" + evrakno.Text + "','" + kasaadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";
                    string komut5 = "update kasakarti set alacak='" + tutar.Text + "' where kasaadi='" + kasaadi.Text + "'";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                    OleDbCommand komutsatir5 = new OleDbCommand(komut5, con);
                    komutsatir.Connection = con;
                    komutsatir3.Connection = con;
                    komutsatir4.Connection = con;
                    komutsatir5.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();
                    komutsatir4.ExecuteNonQuery();
                    komutsatir5.ExecuteNonQuery();
                    con.Close();
                    listele();
                    MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from kasacikis", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kasakarti a = new kasakarti();
            a.label7.Text = "kasacikis";
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "kasacikis";
            a.Show();
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void iExit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void calendarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenicari a = new yenicari();
            a.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            kasakarti a = new kasakarti();
            a.Show();
        }
    }
}