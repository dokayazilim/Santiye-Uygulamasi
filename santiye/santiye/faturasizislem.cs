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
    public partial class faturasizislem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public faturasizislem()
        {
            InitializeComponent();
        }

        private void faturasizislem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet33.faturasizislem' table. You can move, or remove it, as needed.
            this.faturasizislemTableAdapter1.Fill(this.onmuhasebeDataSet33.faturasizislem);
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO faturasizislem(cariadi,tarih,evrakno,durum,tutar,parabirimi,aciklama,detay)VALUES('" + cariadi.Text + "','" + tarih.Text + "','" + aciklama.Text + "','" + durum.Text + "','" + tutar.Text + "','" + parabirimi.Text + "','" + "" + "','" + "" + "')";


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from faturasizislem", con);
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

                string col1, col2, col3, col4, col5, col6, col7, col8;

                col1 = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                col2 = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
                col3 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
                col4 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
                col5 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
                col6 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
                col7 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
                col8 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

                if (col4 == "Borçlu")
                {

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update faturasizislem set cariadi='" + Convert.ToString(col1) + "',tarih='" + Convert.ToString(col2) + "',evrakno='" + Convert.ToString(col3) + "',durum='" + Convert.ToString(col4) + "',tutar='" + Convert.ToString(col5) + "',parabirimi='" + Convert.ToString(col6) + "',aciklama='" + Convert.ToString(col7) + "',detay='" + Convert.ToString(col8) + "' where evrakno='" + textBox1.Text + "'";
                        string komut2 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "BELGESİZ İŞLEM" + "','" + Convert.ToString(col3) + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col7) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col5) + "','" + "0" + "','" + Convert.ToString(col6) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col1) + "','" + "MERKEZ" + "')";
                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                    }

                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());


                    }
                }
                else if (col4 == "Alacaklı")
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update faturasizislem set cariadi='" + Convert.ToString(col1) + "',tarih='" + Convert.ToString(col2) + "',evrakno='" + Convert.ToString(col3) + "',durum='" + Convert.ToString(col4) + "',tutar='" + Convert.ToString(col5) + "',parabirimi='" + Convert.ToString(col6) + "',aciklama='" + Convert.ToString(col7) + "',detay='" + Convert.ToString(col8) + "' where evrakno='" + textBox1.Text + "'";
                        string komut2 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "BELGESİZ İŞLEM" + "','" + Convert.ToString(col3) + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col7) + "','" + "0" + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col5) + "','" + Convert.ToString(col6) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col1) + "','" + "MERKEZ" + "')";
                        OleDbCommand komutsatir = new OleDbCommand(komut, con);
                        OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                        komutsatir.Connection = con;
                        komutsatir2.Connection = con;
                        komutsatir.ExecuteNonQuery();
                        komutsatir2.ExecuteNonQuery();
                        listele();
                        MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


                    }

                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());


                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
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
               
            }
        }

        private void tasksItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
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
            a.label3.Text = "faturasizislem";
            a.Show();
        }

        private void calendarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
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
                    OleDbCommand komut = new OleDbCommand("delete from faturasizislem where evrakno='" + textBox1.Text + "'");

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