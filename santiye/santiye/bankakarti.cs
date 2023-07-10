using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace santiye
{
    public partial class bankakarti : Form
    {
        public bankakarti()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void bankakarti_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            // TODO: This line of code loads data into the 'onmuhasebeDataSet21.bankakart' table. You can move, or remove it, as needed.
            this.bankakartTableAdapter1.Fill(this.onmuhasebeDataSet21.bankakart);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bankakodu.Clear();
            bankaadi.Clear();
            subeismi.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO bankakart(hesapno,subeadi,subeismi)VALUES('" + bankakodu.Text + "','" + bankaadi.Text + "','" + subeismi.Text + "')";


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

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from bankakart", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label6.Text == "bankahesap")
            {
                yenibankahesabi frm2 = (yenibankahesabi)Application.OpenForms["yenibankahesabi"];
                frm2.bankaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


                this.Hide();
            }
            if (label6.Text == "kredihesap")
            {
                yenikredikarti frm2 = (yenikredikarti)Application.OpenForms["yenikredikarti"];
                frm2.bankaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.hesapno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.subeadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


                this.Hide();
            }

        }
    }
}
