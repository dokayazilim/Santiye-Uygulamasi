using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.OleDb;

namespace santiye
{
    public partial class toplustok : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public toplustok()
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

        private void toplustok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet57.toplustok' table. You can move, or remove it, as needed.
            this.toplustokTableAdapter.Fill(this.onmuhasebeDataSet57.toplustok);
            // TODO: This line of code loads data into the 'onmuhasebeDataSet56.stokkayit' table. You can move, or remove it, as needed.
            this.stokkayitTableAdapter1.Fill(this.onmuhasebeDataSet56.stokkayit);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO toplustok(islemturu,stokadi,stokkodu,depo,tarih,aciklama,satinalanunvan,adisoyadi,birim,miktar,fiyat,parabirimi,kdvorani,kdvsiztutar,nettutar,isk)VALUES('" + "" + "','" + stokadi.Text + "','" + stokkodu.Text + "','" + "MERKEZ" + "','" + tarih.Text + "','" + "" + "','" + satinalanunvan.Text + "','" + adisoyadi.Text + "','" + "" + "','" + miktar.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "0" + "')";


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

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dataGridView1.RowCount >= 10)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {

                string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15, col16, col17;


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
                col14 = dataGridView1[13, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col15 = dataGridView1[14, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
                col16 = dataGridView1[15, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...


                float kdvoran = float.Parse(col13);
                double fiyat = Convert.ToDouble(col11);
                double mktr = Convert.ToDouble(col10);
                double kdvislem = mktr * fiyat * (1 + (kdvoran / 100));
                double kdvsonuc = mktr * (fiyat * kdvoran) / 100;



                double isk = Convert.ToDouble(col16);

                double isktopla = isk;
                double iskbolum = (100 - isktopla) / 100;
                double isksonuc = kdvislem * iskbolum;

                double kdvdiger = (isksonuc * kdvoran) / 100;
                string gun;
                gun = DateTime.Now.ToShortDateString();

                if (col1 == "Alış")
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update toplustok set islemturu='" + Convert.ToString(col1) + "',stokadi='" + Convert.ToString(col2) + "',stokkodu='" + Convert.ToString(col3) + "',depo='" + Convert.ToString(col4) + "',tarih='" + Convert.ToString(col5) + "',aciklama='" + Convert.ToString(col6) + "',satinalanunvan='" + Convert.ToString(col7) + "',adisoyadi='" + Convert.ToString(col8) + "',birim='" + Convert.ToString(col9) + "',miktar='" + Convert.ToString(col10) + "',fiyat='" + Convert.ToString(col11) + "',parabirimi='" + Convert.ToString(col12) + "',kdvorani='" + Convert.ToString(col13) + "',kdvsiztutar='" + kdvsonuc + "',nettutar='" + isksonuc + "',isk='" + Convert.ToString(col16) + "' where stokkodu='" + textBox1.Text + "'";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - ALIŞ İŞLEMİ " + "','" + "" + "','" + Convert.ToString(col5) + "','" + Convert.ToString(col6) + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + "0" + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col8) + "','" + "MERKEZ" + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ - ALIŞ İŞLEMİ" + "','" + "" + "','" + "MERKEZ" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col9) + "','" + "0" + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + Convert.ToString(col13) + "','" + "PEŞİN" + "')";

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
                else if (col1 == "Satış")
                {

                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update toplustok set islemturu='" + Convert.ToString(col1) + "',stokadi='" + Convert.ToString(col2) + "',stokkodu='" + Convert.ToString(col3) + "',depo='" + Convert.ToString(col4) + "',tarih='" + Convert.ToString(col5) + "',aciklama='" + Convert.ToString(col6) + "',satinalanunvan='" + Convert.ToString(col7) + "',adisoyadi='" + Convert.ToString(col8) + "',birim='" + Convert.ToString(col9) + "',miktar='" + Convert.ToString(col10) + "',fiyat='" + Convert.ToString(col11) + "',parabirimi='" + Convert.ToString(col12) + "',kdvorani='" + Convert.ToString(col13) + "',kdvsiztutar='" + kdvsonuc + "',nettutar='" + isksonuc + "',isk='" + Convert.ToString(col16) + "' where stokkodu='" + textBox1.Text + "'";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ - SATIŞ İŞLEMİ " + "','" + "" + "','" + Convert.ToString(col5) + "','" + Convert.ToString(col6) + "','" + "0" + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col8) + "','" + "MERKEZ" + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ - SATIŞ İŞLEMİ" + "','" + "" + "','" + "MERKEZ" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col9) + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + "0" + "','" + Convert.ToString(col13) + "','" + "PEŞİN" + "')";

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
                else if (col1 == "Alış İade")
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update toplustok set islemturu='" + Convert.ToString(col1) + "',stokadi='" + Convert.ToString(col2) + "',stokkodu='" + Convert.ToString(col3) + "',depo='" + Convert.ToString(col4) + "',tarih='" + Convert.ToString(col5) + "',aciklama='" + Convert.ToString(col6) + "',satinalanunvan='" + Convert.ToString(col7) + "',adisoyadi='" + Convert.ToString(col8) + "',birim='" + Convert.ToString(col9) + "',miktar='" + Convert.ToString(col10) + "',fiyat='" + Convert.ToString(col11) + "',parabirimi='" + Convert.ToString(col12) + "',kdvorani='" + Convert.ToString(col13) + "',kdvsiztutar='" + kdvsonuc + "',nettutar='" + isksonuc + "',isk='" + Convert.ToString(col16) + "' where stokkodu='" + textBox1.Text + "'";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA GİRİŞ - ALIŞ İADE İŞLEMİ " + "','" + "" + "','" + Convert.ToString(col5) + "','" + Convert.ToString(col6) + "','" + "0" + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col8) + "','" + "MERKEZ" + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA GİRİŞ - ALIŞ İADE İŞLEMİ" + "','" + "" + "','" + "MERKEZ" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col9) + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + "0" + "','" + Convert.ToString(col13) + "','" + "PEŞİN" + "')";

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
                else if (col1 == "Satış İade")
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection();
                        con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                        con.Open();

                        string komut = "update toplustok set islemturu='" + Convert.ToString(col1) + "',stokadi='" + Convert.ToString(col2) + "',stokkodu='" + Convert.ToString(col3) + "',depo='" + Convert.ToString(col4) + "',tarih='" + Convert.ToString(col5) + "',aciklama='" + Convert.ToString(col6) + "',satinalanunvan='" + Convert.ToString(col7) + "',adisoyadi='" + Convert.ToString(col8) + "',birim='" + Convert.ToString(col9) + "',miktar='" + Convert.ToString(col10) + "',fiyat='" + Convert.ToString(col11) + "',parabirimi='" + Convert.ToString(col12) + "',kdvorani='" + Convert.ToString(col13) + "',kdvsiztutar='" + kdvsonuc + "',nettutar='" + isksonuc + "',isk='" + Convert.ToString(col16) + "' where stokkodu='" + textBox1.Text + "'";
                        string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "KASA ÇIKIŞ - SATIŞ İADE İŞLEMİ " + "','" + "" + "','" + Convert.ToString(col5) + "','" + Convert.ToString(col6) + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + "0" + "','" + Convert.ToString(col12) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col8) + "','" + "MERKEZ" + "')";
                        string komut4 = "insert into kasahareket(islemturu,evrakno,kasaadi,tarih,aciklama,cariadi,kdvsizgiren,kdvsizcikan,girentutar,cikantutar,parabirimi,odemesekli) values('" + "KASA ÇIKIŞ - SATIŞ İADE İŞLEMİ" + "','" + "" + "','" + "MERKEZ" + "','" + Convert.ToString(col6) + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col9) + "','" + "0" + "','" + kdvdiger + "','" + "0" + "','" + isksonuc + "','" + Convert.ToString(col13) + "','" + "PEŞİN" + "')";

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

                            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stokkodu.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            stokadi.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();


        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from toplustok", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

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
                iFind.PerformClick();
            }
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
            col13 = dataGridView1[12, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col14 = dataGridView1[13, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col15 = dataGridView1[14, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...


            float kdvoran = float.Parse(col13);
            double fiyat = Convert.ToDouble(col11);
            double mktr = Convert.ToDouble(col10);
            double kdvislem = fiyat / (1 + (kdvoran / 100));
            double kdvsonuc = (fiyat * kdvoran) / 100;
            /*double sonuc = fiyat - kdvislem;*/


            /*double isk = Convert.ToDouble(col15);

            double isktopla = isk;
            double iskbolum = (100 - isktopla) / 100;
            double isksonuc = kdvislem * iskbolum;*/

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "update toplustok set fiyat='" + kdvislem + "'";
                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
                con.Close();
                listele();
                MessageBox.Show("KDV Ayırma işlemi başarılı.", "Uyarı");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            iskonto a = new iskonto();
            a.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenistok a = new yenistok();
            a.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MessageBox.Show("Kayıt sayısı kısıtlı olduğundan 'Taksitlendirme' işlemi gerçekleştirilemez.", "Uyarı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (satinalanunvan.Text == "Cari")
            {
                carikart a = new carikart();
                a.label3.Text = "toplustokcari";
                a.Show();
            }
            else if (satinalanunvan.Text == "Personel")
            {
                personelkayit a = new personelkayit();
                a.label2.Text = "toplustok";
                a.Show();
            }
            else if (satinalanunvan.Text == "Yetkili")
            {
                carikart a = new carikart();
                a.label3.Text = "toplustokyetkili";
                a.Show();
            }
            else
            {
                MessageBox.Show("Lütfen 'Satın Alan Ünvan' seçiniz!", "Uyarı");

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
    }
}