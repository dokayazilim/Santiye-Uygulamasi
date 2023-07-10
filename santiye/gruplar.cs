using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace santiye
{
    public partial class gruplar : Form
    {
        public gruplar()
        {
            InitializeComponent();
        }

        private void gruplar_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            // TODO: This line of code loads data into the 'gruplarDataSet1.grup' table. You can move, or remove it, as needed.
            this.grupTableAdapter.Fill(this.gruplarDataSet1.grup);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\gruplar.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from grup", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label8.Text == "personel")
            {
                yenipersonel frm2 = (yenipersonel)Application.OpenForms["yenipersonel"];
                frm2.personelgrubu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();             
                

                this.Hide();
            }
            if (label8.Text == "stok")
            {
                yenistok frm2 = (yenistok)Application.OpenForms["yenistok"];
                frm2.grupkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm2.grupadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();


                this.Hide();
            }
            if (label8.Text == "kasaavans")
            {
                avansmaas frm2 = (avansmaas)Application.OpenForms["avansmaas"];
                
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
            if (kasano.Text == "")
            {
                MessageBox.Show("'Kasa No' alanı boş geçilemez!","Uyarı");
            }
            else if (kasaadi.Text == "")
            {
                MessageBox.Show("'Kasa Adı' alanı boş geçilemez!", "Uyarı");
            }
            else
            {
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\gruplar.accdb; Persist Security Info=False;";
                    con.Open();

                    string komut = "INSERT INTO grup(grupno,grupadi,bakiye,parabirimi,borc,alacak)VALUES('" + kasano.Text + "','" + kasaadi.Text + "','" + bakiye.Text + "','" + parabirimi.Text + "','" + "0" + "','" + "0" + "')";


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
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kasano.Clear();
            kasaadi.Clear();
            bakiye.Clear();
            parabirimi.Text = "TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
