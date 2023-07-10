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
    public partial class satisveresiye : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public satisveresiye()
        {
            InitializeComponent();
        }

        private void satisveresiye_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartDataSet48.veresiyesatisfatura' table. You can move, or remove it, as needed.
            this.veresiyesatisfaturaTableAdapter.Fill(this.onmuhasebesmartDataSet48.veresiyesatisfatura);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenistok a = new yenistok();
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
    }
}