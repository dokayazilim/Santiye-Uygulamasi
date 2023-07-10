using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace santiye
{
    public partial class hesapmakinesi : Form
    {
        public hesapmakinesi()
        {
            InitializeComponent();
        }
        bool hesap = false;
        double sayi1 = 0;
        char islem = '=';
        private void hesapmakinesi_Load(object sender, EventArgs e)
        {

        }
        private double Hesapla()
        {
            // Burada hesaplarımızın gerçekleştiği kısmı fonksiyon yapmamızın sebebi  bu işlemi hem eşittire basıldığında 
            // hemde 4,-,* ve / işlemleri ile devam ederken kullanmamızdır. Yani ardışık olarak işlem yapabilmek.

            try
            {
                hesap = false;
                switch (islem)
                {
                    case '+': return sayi1 + double.Parse(txtEkran.Text);
                    case '-': return sayi1 - double.Parse(txtEkran.Text);
                    case '/': return sayi1 / double.Parse(txtEkran.Text);
                    case '*': return sayi1 * double.Parse(txtEkran.Text);
                }
            }
            catch
            {
                MessageBox.Show("Birşeyler ters gitti.");
            }
            return 0;
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text.IndexOf(",") == -1 && txtEkran.Text.Length > 0)
                txtEkran.Text += ",";
        }

        private void hesapmakinesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                txtEkran.Text += e.KeyChar;

            if (e.KeyChar == '+')
                btnTopla.PerformClick();  // PerformClick fonksiyonu ekrandaki tuşu sanal olarak tıklatır.
            if (e.KeyChar == '-')
                btnCikar.PerformClick();
            if (e.KeyChar == '*')
                btnCarp.PerformClick();
            if (e.KeyChar == '/')
                btnBol.PerformClick();
            if (e.KeyChar == 13)   // 13 Enter tuşunun ASCİİ karşılığıdır
                btnEsittir.PerformClick();
            if (e.KeyChar == ',')
                btnVirgul.PerformClick();
            if (e.KeyChar == 8)  // 8 Backspace tuşunun ASCİİ karşılığıdır
                txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            lblIslem.Text += txtEkran.Text;
            txtEkran.Text = Hesapla().ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "";   // C tuşu Hesap makinesini sıfırlar
            lblIslem.Text = "";
            hesap = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
        }

        private void btnBol_Click_1(object sender, EventArgs e)
        {
            //Burada bir fonksiyon yazarak tüm işlem butonlarının Click eventlerini aynı fonksiyona yönlendirdik
            // Bu sayede gereksiz kod tekrarını engellemiş olduk

            Button btn = (Button)sender;  // sender değişkeni bu fonksiyonun çalışmasına vesile olan nesneyi tutamaktadır
            lblIslem.Text += txtEkran.Text + btn.Text[0];

            /* bool türündeki hesap değişkeni ile 1. adımda sadece sayıyı doğrudan değişkene atadık
             * 2. adımda ise hesap true olduğu için sayı1 değişkenine ekrandaki sayıyı değilde bir önceki işlemin sonucunu 
             * hesaplayarak  çıkan sonucu atamış olduk
             */

            if (hesap)
                sayi1 = Hesapla();
            else
                sayi1 = double.Parse(txtEkran.Text);

            islem = btn.Text[0]; // burada char türündeki islem değişkenine butonun üzerinde yazan işlemi atamış olduk
            txtEkran.Text = "";
            hesap = true;  // bu fonksiyon 2. kez çağırıldığında  hesap yapılacağını belirttik.

        }
    }
}
