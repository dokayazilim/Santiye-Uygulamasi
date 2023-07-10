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
    public partial class caricari : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public caricari()
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

        private void caricari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet25.caricari' table. You can move, or remove it, as needed.
            this.caricariTableAdapter1.Fill(this.onmuhasebeDataSet25.caricari);
         

        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO caricari(tarih,cariadi,bakiye,cariadidiger,bakiyediger,tutar,parabirimi,aciklama)VALUES('" + tarih.Text + "','" + cariadi.Text + "','" + bakiye.Text + "','" + cariadidiger.Text + "','" + bakiyediger.Text + "','" + "" + "','" + "" + "','" + aciklama.Text + "')";


                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from caricari", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            
                string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15;

                col1 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                col2 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
                col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
                col5 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
                col6 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
                col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
                col8 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

                double baki = Convert.ToDouble(bakiye.Text);
                double ttr = Convert.ToDouble(col6);
                double sonuc = baki - ttr;

                double baki2 = Convert.ToDouble(bakiyediger.Text);
                double ttr2 = Convert.ToDouble(col6);
                double sonuc2 = baki2 + ttr2;

                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "update caricari set tarih='" + Convert.ToString(col1) + "',cariadi='" + Convert.ToString(col2) + "',bakiye='" + Convert.ToString(col3) + "',cariadidiger='" + Convert.ToString(col4) + "',bakiyediger='" + Convert.ToString(col5) + "',tutar='" + Convert.ToString(col6) + "',parabirimi='" + Convert.ToString(col7) + "',aciklama='" + Convert.ToString(col8) + "' where cariadi='" + textBox1.Text + "'";
                    string komut2 = "update carikart set bakiye='" + sonuc + "' where adisoyadi='" + cariadi.Text + "'";
                    string komut3 = "update carikart set bakiye='" + sonuc2 + "' where adisoyadi='" + cariadidiger.Text + "'";
                    string komut5 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - PARA TRANSFER" + "','" + "" + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col8) + "','" + "0" + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col2) + "','" + "MERKEZ" + "')";
                    string komut6 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ - PARA TRANSFER" + "','" + "" + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col8) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col6) + "','" + "0" + "','" + Convert.ToString(col7) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col4) + "','" + "MERKEZ" + "')";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    OleDbCommand komutsatir5 = new OleDbCommand(komut5, con);
                    OleDbCommand komutsatir6 = new OleDbCommand(komut6, con);
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();
                    komutsatir5.ExecuteNonQuery();
                    komutsatir6.ExecuteNonQuery();
                    con.Close();
                    listele();



                }

                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iSave.PerformClick();
            }

            else if (e.KeyCode == Keys.F5)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {
                iExit.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                iFind.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "bankacariadi";
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "bankacariadidiger";
            a.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenicari a = new yenicari();
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
    }
}