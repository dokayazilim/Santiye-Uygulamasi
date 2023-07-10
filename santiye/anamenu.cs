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
    public partial class anamenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapmakinesi a = new hesapmakinesi();
            a.Show();
        }

        private void yeniCariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenicari a = new yenicari();
            a.Show();
        }

        private void yeniKasaKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasakarti a = new kasakarti();
            a.Show();
        }

        private void alınanÇeklerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alinancek a = new alinancek();
            a.Show();
        }

        private void verilenÇeklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilencek a = new verilencek();
            a.Show();
        }

        private void alınanSenetlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alinansenet a = new alinansenet();
            a.Show();
        }

        private void verilenSenetlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            verilensenet a = new verilensenet();
            a.Show();
        }

        private void alışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisislemi a = new alisislemi();
            a.Show();
        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisislemi a = new satisislemi();
            a.Show();
        }

        private void alışİadeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisiade a = new alisiade();
            a.Show();
        }

        private void satışİadeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisiade a = new satisiade();
            a.Show();
        }

        private void yeniFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisfatura a = new alisfatura();
            a.Show();
        }

        private void alınanTekliflerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinanteklif a = new alinanteklif();
            a.Show();
        }

        private void verilenTekliflerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verilenteklif a = new verilenteklif();
            a.Show();
        }

        private void satışFaturalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisfatura a = new satisfatura();
            a.Show();
        }

        private void alıştanİadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisiadefatura a = new alisiadefatura();
            a.Show();
        }

        private void satıştanİadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisfaturaiade a = new satisfaturaiade();
            a.Show();
        }

        private void yeniPersonelKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenipersonel a = new yenipersonel();
            a.Show();
        }

        private void güncelDövizKuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dovizkuru a = new dovizkuru();
            a.Show();
        }

        private void çekHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cekhareket a = new cekhareket();
            a.Show();
        }

        private void senetHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            senethareket a = new senethareket();
            a.Show();
        }

        private void kasaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasagiris a = new kasagiris();
            a.Show();
        }

        private void kasaÇıkışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasacikis a = new kasacikis();
            a.Show();
        }

        private void kasaHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasahareket a = new kasahareket();
            a.Show();
        }

        private void yeniStokKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenistok a = new yenistok();
            a.Show();
        }

        private void gelenHavalelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gelenhavale a = new gelenhavale();
            a.Show();
        }

        private void gönderilenHavalelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gidenhavale a = new gidenhavale();
            a.Show();
        }

        private void yeniBankaKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankakarti a = new bankakarti();
            a.Show();
        }

        private void yeniBankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenibankahesabi a = new yenibankahesabi();
            a.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paracekme a = new paracekme();
            a.Show();
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parayatirma a = new parayatirma();
            a.Show();
        }

        private void bankadanCariyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankacari a = new bankacari();
            a.Show();
        }

        private void caridenBankayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caribanka a = new caribanka();
            a.Show();
        }

        private void bankadanBankayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankabanka a = new bankabanka();
            a.Show();
        }

        private void caridenCariyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caricari a = new caricari();
            a.Show();
        }

        private void bankaKredileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankakredi a = new bankakredi();
            a.Show();
        }

        private void bankaHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankahareket a = new bankahareket();
            a.Show();
        }

        private void bankaHesaplarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankahesap a = new bankahesap();
            a.Show();
        }

        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkayitlari a = new stokkayitlari();
            a.Show();
        }

        private void stokHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokhareket a = new stokhareket();
            a.Show();
        }

        private void cariKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carikart a = new carikart();
            a.Show();
        }

        private void borçAlacakEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borcekle a = new borcekle();
            a.Show();
        }

        private void cariListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carihareket a = new carihareket();
            a.Show();
        }

        private void yeniKrediKartHesabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenikredikarti a = new yenikredikarti();
            a.Show();
        }

        private void krediKartıHesaplarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kredikarthesaplari a = new kredikarthesaplari();
            a.Show();
        }

        private void tahsilatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borctahsilat a = new borctahsilat();
            a.Show();
        }

        private void avansMaaşÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avansmaas a = new avansmaas();
            a.Show();
        }

        private void yeniFişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yeniFişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void fişHareketiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void topluStokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toplustok a = new toplustok();
            a.Show();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Oturumunuz kapatılıyor! Çıkış yapmadan önce kayıtlarınızın kaydedilmiş olduğundan emin olunuz! Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void satıcılarHesabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saticilarhesabi a = new saticilarhesabi();
            a.Show();
        }

        private void personelHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelhareket a = new personelhareket();
            a.Show();
        }

        private void personelKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelkayit a = new personelkayit();
            a.Show();
        }

        private void yeniKasaKartıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kasakarti a = new kasakarti();
            a.Show();
        }

        private void kargoTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kargogider a = new kargogider();
            a.Show();
        }

        private void gelirGiderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidefter a = new yenidefter();
            a.Show();
        }

        private void faturasızİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faturasizislem a = new faturasizislem();
            a.Show();
        }

        private void faturaAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faturalar a = new faturalar();
            a.Show();
        }

        private void mutabakatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mutabakat a = new mutabakat();
            a.Show();
        }

        private void baBsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            babs a = new babs();
            a.Show();
        }

        private void veresiyeliAlışFaturalarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alisveresiye a = new alisveresiye();
            a.Show();
        }

        private void veresiyeliSatışFaturalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satisveresiye a = new satisveresiye();
            a.Show();
        }

        private void çekTahsilatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cektahsilatibanka a = new cektahsilatibanka();
            a.Show();
        }

        private void senetTahsilatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cektahsilaticari a = new cektahsilaticari();
            a.Show();
        }

        private void ciroİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cekciro a = new cekciro();
            a.Show();
        }

        private void senetCiroİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            senetciro a = new senetciro();
            a.Show();
        }

        private void nakdenMerkezMuhasebedenAlınanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muhasebegiren a = new muhasebegiren();
            a.Show();
        }

        private void aylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aylikrapor a = new aylikrapor();
            a.Show();
        }

        private void yıllıkRapoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yillikrapor a = new yillikrapor();
            a.Show();
        }

        private void tümİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alissatisislem a = new alissatisislem();
            a.Show();
        }

        private void fişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fisislemi a = new fisislemi();
            a.Show();
        }

        private void avansMaaşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avansmaas a = new avansmaas();
            a.Show();
        }

        private void borçAlacakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borcekle a = new borcekle();
            a.Show();
        }

        private void merkezMuhasebedenAlınanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muhasebegiren a = new muhasebegiren();
            a.Show();
        }

        private void kargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kargo a = new kargo();
            a.Show();
        }

        private void zarfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zarf a = new zarf();
            a.Show();
        }

        private void devirİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devir a = new devir();
            a.Show();
        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            icmal a = new icmal();
            a.Show();
        }

        private void icmalRaporuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            icmal a = new icmal();
            a.Show();
        }

        private void grupkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void yeniGrupTanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gruplar a = new gruplar();
            a.Show();
        }

        private void grupHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gruphareket a = new gruphareket();
            a.Show();
        }

        private void versiyonBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vs a = new vs();
            a.Show();
        }

        private void uzaktanDestekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("yardim.exe");
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletisim a = new iletisim();
            a.Show();
        }

        private void avansMaaşEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avansmaas a = new avansmaas();
            a.Show();
        }

        private void borçAlacakEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            borcekle a = new borcekle();
            a.Show();
        }

        private void veresiyeliSatışFaturalarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            satisveresiye a = new satisveresiye();
            a.Show();
        }

        private void bilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yedekalpc a = new yedekalpc();
            a.Show();
        }
    }
}