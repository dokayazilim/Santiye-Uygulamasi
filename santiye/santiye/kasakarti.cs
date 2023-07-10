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
    public partial class kasakarti : Form
    {
        public kasakarti()
        {
            InitializeComponent();
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

        private void dövizTÜrüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dovizkuru a = new dovizkuru();
            a.Show();
        }

        private void kasakarti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet40.kasakarti' table. You can move, or remove it, as needed.
            this.kasakartiTableAdapter1.Fill(this.onmuhasebeDataSet40.kasakarti);
            label7.Visible = false;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from kasakarti", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label7.Text == "kasagiris")
            {
                kasagiris frm2 = (kasagiris)Application.OpenForms["kasagiris"];
                frm2.kasaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                

                this.Hide();

            }
            if (label7.Text == "kasacikis")
            {
                kasacikis frm2 = (kasacikis)Application.OpenForms["kasacikis"];
                frm2.kasaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();

            }
            if (label7.Text == "kasaavans")
            {
                avansmaas frm2 = (avansmaas)Application.OpenForms["avansmaas"];
                frm2.evrakno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();

            }
            if (label7.Text == "tahsil")
            {
                borctahsilat frm2 = (borctahsilat)Application.OpenForms["borctahsilat"];
                frm2.evrakno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();

            }
            if (label7.Text == "muhasebegiren")
            {
                muhasebegiren frm2 = (muhasebegiren)Application.OpenForms["muhasebegiren"];
                frm2.kasaadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();

            }
            if (label7.Text == "borcekle")
            {
                borcekle frm2 = (borcekle)Application.OpenForms["borcekle"];
                frm2.evrakno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();

            }
        }

        private void aktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktar a = new aktar();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebe.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "INSERT INTO kasakarti(kasano,kasaadi,bakiye,parabirimi,borc,alacak)VALUES('" + kasano.Text + "','" + kasaadi.Text + "','" + bakiye.Text + "','" + parabirimi.Text + "','" + "0" + "','" + "0" + "')";


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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasano.Clear();
            kasaadi.Clear();
            bakiye.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kasano.Clear();
            kasaadi.Clear();
            bakiye.Clear();
        }
    }
}
