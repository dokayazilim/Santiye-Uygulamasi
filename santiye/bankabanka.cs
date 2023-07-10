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
    public partial class bankabanka : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bankabanka()
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

        private void bankabanka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet17.bankabanka' table. You can move, or remove it, as needed.
            this.bankabankaTableAdapter1.Fill(this.onmuhasebeDataSet17.bankabanka);
            label9.Visible = false;
            label10.Visible = false;
           

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenibankahesabi a = new yenibankahesabi();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO bankabanka(tarih,bankaadi,subeadi,hesapno,cariadi,bankaadidiger,subeadidiger,hesapnodiger,cariadidiger,odemeyeri,tutar,parabirimi,aciklama)VALUES('" + tarih.Text + "','" + bankaadi.Text + "','" + subeadi.Text + "','" + hesapno.Text + "','" + "Demo" + "','" + bankaadidiger.Text + "','" + subeadidiger.Text + "','" + hesapnodiger.Text + "','" + cariadidiger.Text + "','" + "BANKA" + "','" + "" + "','" + "" + "','" + "" + "')";


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from bankabanka", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankahesap a = new bankahesap();
            a.label7.Text = "bankaparatransfer";
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bankahesap a = new bankahesap();
            a.label7.Text = "bankaparatransferdiger";
            a.Show();
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
           

                string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13;

                col1 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                col2 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
                col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
                col5 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
                col6 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
                col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
                col8 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col9 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col10 = dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col11 = dataGridView1[10, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col12 = dataGridView1[11, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col13 = dataGridView1[12, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

                double baki = Convert.ToDouble(bakiye.Text);
                double ttr = Convert.ToDouble(col11);
                double sonuc = baki - ttr;

                double baki2 = Convert.ToDouble(bakiyediger.Text);
                double ttr2 = Convert.ToDouble(col11);
                double sonuc2 = baki2 + ttr2;

                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "update bankabanka set tarih='" + Convert.ToString(col1) + "',bankaadi='" + Convert.ToString(col2) + "',subeadi='" + Convert.ToString(col3) + "',hesapno='" + Convert.ToString(col4) + "',cariadi='" + Convert.ToString(col5) + "',bankaadidiger='" + Convert.ToString(col6) + "',subeadidiger='" + Convert.ToString(col7) + "',hesapnodiger='" + Convert.ToString(col8) + "',cariadidiger='" + Convert.ToString(col9) + "',odemeyeri='" + Convert.ToString(col10) + "',tutar='" + Convert.ToString(col11) + "',parabirimi='" + Convert.ToString(col12) + "',aciklama='" + Convert.ToString(col13) + "'  where cariadi='" + textBox1.Text + "'";
                    string komut2 = "update bankahesap set bakiye='" + sonuc + "' where cariadi='" + cariadi.Text + "'";
                    string komut3 = "update bankahesap set bakiye='" + sonuc2 + "' where cariadi='" + cariadidiger.Text + "'";
                    string komut4 = "insert into bankahareket(cariadi,islemtarihi,islemturu,bankaadi,subeadi,hesapno,bakiye,dekontno,girentutar,cikantutar,parabirimi,aciklama) values('" + Convert.ToString(col5) + "','" + Convert.ToString(col1) + "','" + "BANKA ÇIKIŞ - BANKADAN BANKAYA PARA TRANSFERİ" + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col3) + "','" + Convert.ToString(col4) + "','" + bakiye.Text + "','" + "" + "','" + "0" + "','" + Convert.ToString(col11) + "','" + Convert.ToString(col12) + "','" + Convert.ToString(col13) + "')";
                    string komut7 = "insert into bankahareket(cariadi,islemtarihi,islemturu,bankaadi,subeadi,hesapno,bakiye,dekontno,girentutar,cikantutar,parabirimi,aciklama) values('" + Convert.ToString(col9) + "','" + Convert.ToString(col1) + "','" + "BANKA GİRİŞ - BANKADAN BANKAYA PARA TRANSFERİ" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col8) + "','" + bakiyediger.Text + "','" + "" + "','" + Convert.ToString(col11) + "','" + "0" + "','" + Convert.ToString(col12) + "','" + Convert.ToString(col13) + "')";
                    string komut5 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - PARA TRANSFER" + "','" + "" + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col13) + "','" + "0" + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col11) + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col5) + "','" + "MERKEZ" + "')";
                    string komut6 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ - PARA TRANSFER" + "','" + "" + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col13) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col11) + "','" + "0" + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col9) + "','" + "MERKEZ" + "')";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                    OleDbCommand komutsatir5 = new OleDbCommand(komut5, con);
                    OleDbCommand komutsatir6 = new OleDbCommand(komut6, con);
                    OleDbCommand komutsatir7 = new OleDbCommand(komut7, con);
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    komutsatir4.Connection = con;
                    komutsatir5.Connection = con;
                    komutsatir6.Connection = con;
                    komutsatir7.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
                    komutsatir3.ExecuteNonQuery();
                    komutsatir4.ExecuteNonQuery();
                    komutsatir5.ExecuteNonQuery();
                    komutsatir6.ExecuteNonQuery();
                    komutsatir7.ExecuteNonQuery();                   
                    
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
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
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