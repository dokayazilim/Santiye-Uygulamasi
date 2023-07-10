﻿using System;
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
    public partial class parayatirma : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public parayatirma()
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

        private void parayatirma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet44.parayatirma' table. You can move, or remove it, as needed.
            this.parayatirmaTableAdapter.Fill(this.onmuhasebeDataSet44.parayatirma);
         

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO parayatirma(cariadi,islemtarihi,bankaadi,subeadi,hesapno,bakiye,dekontno,tutar,parabirimi,aciklama)VALUES('" + cariadi.Text + "','" + tarih.Text + "','" + serino.Text + "','" + subeadi.Text + "','" + hesapno.Text + "','" + bakiye.Text + "','" + bordrono.Text + "','" + "" + "','" + "" + "','" + aciklama.Text + "')";


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from parayatirma", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankahesap a = new bankahesap();
            a.label7.Text = "parayatirma";
            a.Show();
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
           
                string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10;

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





                double baki = Convert.ToDouble(bakiye.Text);
                double ttr = Convert.ToDouble(col8);
                double sonuc = baki + ttr;


                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "Update parayatirma set cariadi='" + Convert.ToString(col1) + "',islemtarihi='" + Convert.ToString(col2) + "',bankaadi='" + Convert.ToString(col3) + "',subeadi='" + Convert.ToString(col4) + "',hesapno='" + Convert.ToString(col5) + "',bakiye='" + Convert.ToString(col6) + "',dekontno='" + Convert.ToString(col7) + "',tutar='" + Convert.ToString(col8) + "',parabirimi='" + Convert.ToString(col9) + "',aciklama='" + Convert.ToString(col10) + "' where dekontno='" + textBox1.Text + "'";
                    string komut2 = "update bankahesap set bakiye='" + sonuc + "' where cariadi='" + cariadi.Text + "'";
                    string komut3 = "insert into carihareket(islemturu,evrakno,tarih,aciklama,kdvsizborc,kdvsizalacak,borc,alacak,parabirimi,odemesekli,vadetarihi,odemetarihi,odemeyeri) values('" + "BANKA GİRİŞ - PARA YATIRMA" + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col2) + "','" + Convert.ToString(col10) + "','" + "0" + "','" + "0" + "','" + Convert.ToString(col8) + "','" + "0" + "','" + Convert.ToString(col9) + "','" + "PEŞİN" + "','" + "" + "','" + Convert.ToString(col1) + "','" + "BANKA" + "')";
                    string komut4 = "insert into bankahareket(cariadi,islemtarihi,islemturu,bankaadi,subeadi,hesapno,bakiye,dekontno,girentutar,cikantutar,parabirimi,aciklama) values('" + Convert.ToString(col1) + "','" + Convert.ToString(col2) + "','" + "BANKA GİRİŞ - PARA YATIRMA" + "','" + Convert.ToString(col3) + "','" + Convert.ToString(col4) + "','" + Convert.ToString(col5) + "','" + bakiye.Text + "','" + Convert.ToString(col7) + "','" + Convert.ToString(col8) + "','" + "0" + "','" + Convert.ToString(col9) + "','" + Convert.ToString(col10) + "')";
                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                    OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                    OleDbCommand komutsatir4 = new OleDbCommand(komut4, con);
                    komutsatir.Connection = con;
                    komutsatir2.Connection = con;
                    komutsatir3.Connection = con;
                    komutsatir4.Connection = con;
                    komutsatir.ExecuteNonQuery();
                    komutsatir2.ExecuteNonQuery();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
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

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenibankahesabi a = new yenibankahesabi();
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