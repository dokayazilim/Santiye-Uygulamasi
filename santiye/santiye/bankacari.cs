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
    public partial class bankacari : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bankacari()
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

        private void bankacari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet18.bankacari' table. You can move, or remove it, as needed.
            this.bankacariTableAdapter1.Fill(this.onmuhasebeDataSet18.bankacari);
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO bankacari(bankaadi,subeadi,hesapno,bakiye,cariadi,tarih,cariadidiger,bakiyetr,odemeyeri,tutar,parabirimi,aciklama)VALUES('" + bankaadi.Text + "','" + subeadi.Text + "','" + hesapno.Text + "','" + bakiye.Text + "','" + cariadi.Text + "','" + tarih.Text + "','" + cariadidiger.Text + "','" + bakiyediger.Text + "','" + "BANKA" + "','" + "" + "','" + "" + "','" + "" + "')";


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from bankacari", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dataGridView1.RowCount >= 10)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
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
                col9 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col10 = dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col11 = dataGridView1[10, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col12 = dataGridView1[11, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

                double baki = Convert.ToDouble(bakiye.Text);
                double ttr = Convert.ToDouble(col10);
                double sonuc = baki - ttr;

                double baki2 = Convert.ToDouble(bakiyediger.Text);
                double ttr2 = Convert.ToDouble(col10);
                double sonuc2 = baki2 + ttr2;

                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "update bankacari set bankaadi='" + Convert.ToString(col1) + "',subeadi='" + Convert.ToString(col2) + "',hesapno='" + Convert.ToString(col3) + "',bakiye='" + Convert.ToString(col4) + "',cariadi='" + Convert.ToString(col5) + "',tarih='" + Convert.ToString(col6) + "',cariadidiger='" + Convert.ToString(col7) + "',bakiyetr='" + Convert.ToString(col8) + "',odemeyeri='" + Convert.ToString(col9) + "',tutar='" + Convert.ToString(col10) + "',parabirimi='" + Convert.ToString(col11) + "',aciklama='" + Convert.ToString(col12) + "' where cariadi='" + textBox1.Text + "'";
                    string komut2 = "update bankahesap set bakiye='" + sonuc + "' where cariadi='" + cariadi.Text + "'";
                    string komut3 = "update carikart set bakiye='" + sonuc2 + "' where adisoyadi='" + cariadidiger.Text + "'";
                    string komut4 = "insert into bankahareket(cariadi,islemtarihi,islemturu,bankaadi,subeadi,hesapno,bakiye,dekontno,girentutar,cikantutar,parabirimi,aciklama) values('" + Convert.ToString(col5) + "','" + Convert.ToString(col6) + "','" + "BANKA ÇIKIŞ - BANKADAN CARİYE PARA TRANSFERİ" + "','" + Convert.ToString(col1) + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col3) + "','" + bakiye.Text + "','" + "" + "','" + "0" + "','" + Convert.ToString(col10) + "','" + Convert.ToString(col11) + "','" + Convert.ToString(col12) + "')";
                    string komut7 = "insert into bankahareket(cariadi,islemtarihi,islemturu,bankaadi,subeadi,hesapno,bakiye,dekontno,girentutar,cikantutar,parabirimi,aciklama) values('" + Convert.ToString(col7) + "','" + Convert.ToString(col6) + "','" + "BANKA GİRİŞ - BANKADAN CARİYE PARA TRANSFERİ" + "','" + "" + "','" + "" + "','" + "" + "','" + bakiyediger.Text + "','" + "" + "','" + Convert.ToString(col10) + "','" + "0" + "','" + Convert.ToString(col11) + "','" + Convert.ToString(col12) + "')";
                    string komut5 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - PARA TRANSFER" + "','" + "" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col12) + "','" + "0" + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col10) + "','" + Convert.ToString(col11) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col5) + "','" + "MERKEZ" + "')";
                    string komut6 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ - PARA TRANSFER" + "','" + "" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col12) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col10) + "','" + "0" + "','" + Convert.ToString(col11) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col7) + "','" + "MERKEZ" + "')";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                    OleDbCommand komutsatir5 = new OleDbCommand(komut5, con);
                    OleDbCommand komutsatir6 = new OleDbCommand(komut6, con);
                    OleDbCommand komutsatir7 = new OleDbCommand(komut7, con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            bankahesap a = new bankahesap();
            a.label7.Text = "bankacari";
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.label3.Text = "bankacari";
            a.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenibankahesabi a = new yenibankahesabi();
            a.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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

        private void trashItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from bankacari where cariadi='" + textBox1.Text + "'");

                    komut.Connection = baglan;

                    komut.ExecuteNonQuery();

                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    textBox1.Clear();




                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}