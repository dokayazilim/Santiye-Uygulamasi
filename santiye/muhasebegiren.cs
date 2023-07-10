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
    public partial class muhasebegiren : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public muhasebegiren()
        {
            InitializeComponent();
        }

        private void muhasebegiren_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet42.muhasebegiren' table. You can move, or remove it, as needed.
            this.muhasebegirenTableAdapter.Fill(this.onmuhasebeDataSet42.muhasebegiren);
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kasakarti a = new kasakarti();
            a.label7.Text = "muhasebegiren";
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO muhasebegiren(cariadi,tarih,aciklama,tutar,parabirimi,evrakno,kasaadi)VALUES('" + cariadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + evrakno.Text + "','" + kasaadi.Text + "')";

                string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "','" + "" + "','" + cariadi.Text + "','" + kasaadi.Text + "')";
                string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ" + "','" + evrakno.Text + "','" + kasaadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + cariadi.Text + "','" + "0" + "','" + "0" + "','" + tutar.Text + "','" + "0" + "','" + parabirimi.Text + "','" + "PEŞİN" + "')";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                komutsatir.Connection = con;
                komutsatir3.Connection = con;
                komutsatir4.Connection = con;

                komutsatir.ExecuteNonQuery();
                komutsatir3.ExecuteNonQuery();
                komutsatir4.ExecuteNonQuery();


               
                con.Close();
                listele();



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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from muhasebegiren", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "muhasebegiren";
            a.Show();
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
    }
}