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
    public partial class kredikarthesaplari : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public kredikarthesaplari()
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

        private void kredikarthesaplari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebeDataSet41.kredikartihesabi' table. You can move, or remove it, as needed.
            this.kredikartihesabiTableAdapter1.Fill(this.onmuhasebeDataSet41.kredikartihesabi);
          

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            yenikredikarti a = new yenikredikarti();
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