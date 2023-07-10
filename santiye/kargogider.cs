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
    public partial class kargogider : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public kargogider()
        {
            InitializeComponent();
        }

        private void kargogider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet6.kargotakip' table. You can move, or remove it, as needed.
            this.kargotakipTableAdapter.Fill(this.onmuhasebeDataSet6.kargotakip);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO kargotakip(kargono,irsaliyeno,kargosirketi,tarih,islemturu,cariadi,adres,urunadi,birim,miktar,tutar,kdvorani,parabirimi,cikismerkez,varismerkez,gonderen,teslimalan,kdvsiztutar,nettutar,aciklama)VALUES('" + faturano.Text + "','" + irsaliyeno.Text + "','" + "" + "','" + tarih.Text + "','" + islemturu.Text + "','" + cariadi.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "')";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.Connection = con;
                komutsatir.ExecuteNonQuery();
                con.Close();
                listele2();
                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Uyarı");


            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }          
        }
        public void listele2()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from kargotakip", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15, col16, col17, col18, col19, col20;

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
            col17 = dataGridView1[16, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col18 = dataGridView1[17, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col19 = dataGridView1[18, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...
            col20 = dataGridView1[19, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...







            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "Update kargotakip set kargono='" + Convert.ToString(col1) + "', irsaliyeno='" + Convert.ToString(col2) + "', kargosirketi='" + Convert.ToString(col3) + "', tarih='" + Convert.ToString(col4) + "', islemturu='" + Convert.ToString(col5) + "', cariadi='" + Convert.ToString(col6) + "', adres='" + Convert.ToString(col7) + "', urunadi='" + Convert.ToString(col8) + "', birim='" + Convert.ToString(col9) + "', miktar='" + Convert.ToString(col10) + "', tutar='" + Convert.ToString(col11) + "', kdvorani='" + Convert.ToString(col12) + "', parabirimi='" + Convert.ToString(col13) + "', cikismerkez='" + Convert.ToString(col14) + "', varismerkez='" + Convert.ToString(col15) + "', gonderen='" + Convert.ToString(col16) + "', teslimalan='" + Convert.ToString(col17) + "', kdvsiztutar='" + Convert.ToString(col18) + "', nettutar='" + Convert.ToString(col19) + "', aciklama='" + Convert.ToString(col20) + "' where kargono='" + textBox1.Text + "'";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);

                komutsatir.Connection = con;


                komutsatir.ExecuteNonQuery();

                con.Close();
                listele2();



            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}