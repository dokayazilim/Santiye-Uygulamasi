using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace santiye
{
    public partial class carikart : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public carikart()
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

        private void carikart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet68.carikart' table. You can move, or remove it, as needed.
            this.carikartTableAdapter3.Fill(this.onmuhasebeDataSet68.carikart);
            // TODO: This line of code loads data into the 'onmuhasebeDataSet66.carikart' table. You can move, or remove it, as needed.
            this.carikartTableAdapter2.Fill(this.onmuhasebeDataSet66.carikart);
            // TODO: This line of code loads data into the 'onmuhasebeDataSet28.carikart' table. You can move, or remove it, as needed.
            this.carikartTableAdapter1.Fill(this.onmuhasebeDataSet28.carikart);
            // TODO: This line of code loads data into the 'onmuhasebeDataSet27.carikart' table. You can move, or remove it, as needed.
            this.carikartTableAdapter.Fill(this.onmuhasebeDataSet27.carikart);
            label3.Visible = false;
         

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label3.Text == "borctahsil")
            {
                borctahsilat frm2 = (borctahsilat)Application.OpenForms["borctahsilat"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
                frm2.parabirimi.Text= dataGridView1.Rows[e.RowIndex].Cells[23].Value.ToString();
               

                this.Hide();
            }
            if (label3.Text == "borcekle")
            {
                borcekle frm2 = (borcekle)Application.OpenForms["borcekle"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.vergino.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
                frm2.vergidairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


                this.Hide();
            }
            if (label3.Text == "bankacari")
            {
                bankacari frm2 = (bankacari)Application.OpenForms["bankacari"];
                frm2.cariadidiger.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.bakiyediger.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();
                


                this.Hide();
            }
            if (label3.Text == "caribanka")
            {
                caribanka frm2 = (caribanka)Application.OpenForms["caribanka"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.bakiyediger.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();



                this.Hide();
            }
            if (label3.Text == "bankacariadi")
            {
                caricari frm2 = (caricari)Application.OpenForms["caricari"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.bakiye.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();



                this.Hide();
            }
            if (label3.Text == "bankacariadidiger")
            {
                caricari frm2 = (caricari)Application.OpenForms["caricari"];
                frm2.cariadidiger.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.bakiyediger.Text = dataGridView1.Rows[e.RowIndex].Cells[22].Value.ToString();



                this.Hide();
            }
            if (label3.Text == "alinancek")
            {
                alinancek frm2 = (alinancek)Application.OpenForms["alinancek"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                



                this.Hide();
            }
            if (label3.Text == "alinansenet")
            {
                alinansenet frm2 = (alinansenet)Application.OpenForms["alinansenet"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alinanteklif")
            {
                alinanteklif frm2 = (alinanteklif)Application.OpenForms["alinanteklif"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alisfatura")
            {
                alisfatura frm2 = (alisfatura)Application.OpenForms["alisfatura"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alisiade")
            {
                alisiade frm2 = (alisiade)Application.OpenForms["alisiade"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alisiadefatura")
            {
                alisiadefatura frm2 = (alisiadefatura)Application.OpenForms["alisiadefatura"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alisislemi")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alisislemicari")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alisislemiyetkili")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "alisveresiye")
            {
                alisveresiye frm2 = (alisveresiye)Application.OpenForms["alisveresiye"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "faturasizislem")
            {
                faturasizislem frm2 = (faturasizislem)Application.OpenForms["faturasizislem"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "fisislemi")
            {
                fisislemi frm2 = (fisislemi)Application.OpenForms["fisislemi"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "kasacikis")
            {
                kasacikis frm2 = (kasacikis)Application.OpenForms["kasacikis"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "kasagiris")
            {
                kasagiris frm2 = (kasagiris)Application.OpenForms["kasagiris"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "muhasebegiren")
            {
                muhasebegiren frm2 = (muhasebegiren)Application.OpenForms["muhasebegiren"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "satisfatura")
            {
                satisfatura frm2 = (satisfatura)Application.OpenForms["satisfatura"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "satisfaturaiade")
            {
                satisfaturaiade frm2 = (satisfaturaiade)Application.OpenForms["satisfaturaiade"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "satisiadecari")
            {
                satisiade frm2 = (satisiade)Application.OpenForms["satisiade"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "satisiadeyetkili")
            {
                satisiade frm2 = (satisiade)Application.OpenForms["satisiade"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "toplustokcari")
            {
                toplustok frm2 = (toplustok)Application.OpenForms["toplustok"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "toplustokyetkili")
            {
                toplustok frm2 = (toplustok)Application.OpenForms["toplustok"];
                frm2.adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "verilencek")
            {
                verilencek frm2 = (verilencek)Application.OpenForms["verilencek"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "verilensenet")
            {
                verilensenet frm2 = (verilensenet)Application.OpenForms["verilensenet"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "verilenteklif")
            {
                verilenteklif frm2 = (verilenteklif)Application.OpenForms["verilenteklif"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "gelir")
            {
                yenidefter frm2 = (yenidefter)Application.OpenForms["yenidefter"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "gider")
            {
                yenidefter frm2 = (yenidefter)Application.OpenForms["yenidefter"];
                frm2.cariadidiger.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "yenibankahesap")
            {
                yenibankahesabi frm2 = (yenibankahesabi)Application.OpenForms["yenibankahesabi"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
            }
            if (label3.Text == "yenikredikarti")
            {
                yenikredikarti frm2 = (yenikredikarti)Application.OpenForms["yenikredikarti"];
                frm2.cariadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();




                this.Hide();
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