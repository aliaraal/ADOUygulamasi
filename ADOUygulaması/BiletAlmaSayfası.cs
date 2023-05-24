using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADOUygulaması
{
    public partial class BiletAlmaSayfası : Form
    {

        public string yazı;
        public string gidistarih1;
        public string yolcutipi1;
        public string yolcuadedi1;
        public BiletAlmaSayfası()
        {
            InitializeComponent();
        }

     

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
            
        }

        private void BiletAlmaSayfası_Load(object sender, EventArgs e)
        {
            
            label10.Text = yazı;
            label1.Text = gidistarih1;
            label21.Text = yolcutipi1;
            label6.Text = yolcuadedi1;
            int s1 = Convert.ToInt32(label6.Text);

            //bandırma
            if (label10.Text== "Yenikapı  ->  Bandırma")
            {
                
                button6.Text = (300 * s1).ToString();
                button7.Text = (300 * s1).ToString() ;
                button8.Text = (300 * s1).ToString();
                button9.Text = (300 * s1).ToString() ;
                if (label21.Text == "Engelli")
                {
                    button6.Text =  (300 * s1 - 30 ).ToString();
                    button7.Text = (300 * s1 - 30).ToString();
                    button8.Text = (300 * s1 - 30).ToString()  ;
                    button9.Text = (300 * s1 - 30).ToString();
                    button10.Text = (300 * s1 - 30).ToString();
                }
                if (label21.Text == "65 Yas Üstü")
                {
                    button6.Text = (300 * s1 - 30 ).ToString() + "₺";
                    button7.Text = (300 * s1 - 30).ToString() + "₺" ;
                    button8.Text = (300 * s1 - 30).ToString() + "₺";
                    button9.Text = (300 * s1 - 30).ToString() + "₺";
                    button10.Text = (300 * s1 - 30).ToString() + "₺";
                }
                if (label21.Text == "Ogrenci")
                {
                    button6.Text = (300 * s1 - 30).ToString() ;
                    button7.Text = (300 * s1 - 30).ToString() ;  
                    button8.Text = (300 * s1 - 30).ToString() ;
                    button9.Text = (300 * s1 - 30).ToString();
                    button10.Text = (300 * s1 - 30).ToString() ;
                }
                label13.Text = "07.00 I 10.00";
                label14.Text = "09.00 I 12.00";
                label16.Text = "15.00 I 18.00";
                label18.Text = "19.00 I 22.00";
                button10.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
            }
            if (label10.Text == "Bandırma  ->  Yenikapı")
            {
                button6.Text = (300 * s1).ToString() ;
                button7.Text = (300 * s1).ToString() ;
                button8.Text = (300 * s1).ToString()  ;
                button9.Text = (300 * s1).ToString() ;
                if (label21.Text == "Engelli")
                {
                    button6.Text = (300 * s1 - 30).ToString() ;
                    button7.Text = (300 * s1 - 30).ToString();
                    button8.Text = (300 * s1 - 30).ToString() ;
                    button9.Text = (300 * s1 - 30).ToString() ;
                    button10.Text = (300 * s1 - 30).ToString() ;
                }
                if (label21.Text == "65 Yas Üstü")
                {
                    button6.Text = (300 * s1 - 30).ToString() ;
                    button7.Text = (300 * s1 - 30).ToString();
                    button8.Text = (300 * s1 - 30).ToString() ;
                    button9.Text = (300 * s1 - 30).ToString();
                    button10.Text = (300 * s1 - 30).ToString() ;
                }
                if (label21.Text == "Ogrenci")
                {
                    button6.Text = (300 * s1 - 30).ToString();
                    button7.Text = (300 * s1 - 30).ToString() ;
                    button8.Text = (300 * s1 - 30).ToString() ;
                    button9.Text = (300 * s1 - 30).ToString() ;
                    button10.Text = (300 * s1 - 30).ToString() ;
                }
                label13.Text = "07.00 I 10.00";
                label14.Text = "09.00 I 12.00";
                label16.Text = "15.00 I 18.00";
                label18.Text = "21.00 I 00.00";
                button10.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
            }
            //bursa
            if (label10.Text == "Yenikapı  ->  Bursa")
            {
                button6.Text = (200 * s1).ToString() ;
                button7.Text = (200 * s1).ToString();
                button8.Text = (200 * s1).ToString() ;
                button9.Text = (200 * s1).ToString() ;
                button10.Text = (200 * s1).ToString() ;

                if (label21.Text == "Engelli")
                {
                    button6.Text = (200 * s1 - 30).ToString() ;
                    button7.Text = (200 * s1 - 30).ToString() ;
                    button8.Text = (200 * s1 - 30).ToString() ;
                    button9.Text = (200 * s1 - 30).ToString();
                    button10.Text = (200 * s1 - 30).ToString() ;
                }
                if (label21.Text == "65 Yas Üstü")
                {
                    button6.Text = (200 * s1 - 30).ToString() ;
                    button7.Text = (200 * s1 - 30).ToString() ;
                    button8.Text = (200 * s1 - 30).ToString() ;
                    button9.Text = (200 * s1 - 30).ToString() ;
                    button10.Text = (200 * s1 - 30).ToString();
                }
                if (label21.Text == "Ogrenci")
                {
                    button6.Text = (200 * s1 - 30).ToString() ;
                    button7.Text = (200 * s1 - 30).ToString();
                    button8.Text = (200 * s1 - 30).ToString() ;
                    button9.Text = (200 * s1 - 30).ToString();
                    button10.Text = (200 * s1 - 30).ToString() ;
                }
                label13.Text = "06.00 I 08.00";
                label14.Text = "09.00 I 11.00";
                label16.Text = "15.00 I 17.00";
                label18.Text = "18.00 I 20.00";
                label28.Text = "20.00 I 22.00";
            }
            if (label10.Text == "Bursa  ->  Yenikapı")
            {
                button6.Text = (200 * s1).ToString() ;
                button7.Text = (200 * s1).ToString() ;
                button8.Text = (200 * s1).ToString() ;
                button9.Text = (200 * s1).ToString();
                button10.Text = (200 * s1).ToString() ;
                if (label21.Text == "Engelli")
                {
                    button6.Text = (200 * s1 - 30).ToString() ;
                    button7.Text = (200 * s1 - 30).ToString() ;
                    button8.Text = (200 * s1 - 30).ToString() ;
                    button9.Text = (200 * s1 - 30).ToString() ;
                    button10.Text = (200 * s1 - 30).ToString();
                }
                if (label21.Text == "65 Yas Üstü")
                {
                    button6.Text = (200 * s1 - 30).ToString() ;
                    button7.Text = (200 * s1 - 30).ToString() ;
                    button8.Text = (200 * s1 - 30).ToString() ;
                    button9.Text = (200 * s1 - 30).ToString() ;
                    button10.Text = (200 * s1 - 30).ToString();
                }
                if (label21.Text == "Ogrenci")
                {
                    button6.Text = (200 * s1 - 30).ToString() ;
                    button7.Text = (200 * s1 - 30).ToString();
                    button8.Text = (200 * s1 - 30).ToString() ;
                    button9.Text = (200 * s1 - 30).ToString();
                    button10.Text = (200 * s1 - 30).ToString();
                }

                label13.Text = "11.00 I 13.00";
                label14.Text = "15.00 I 17.00";
                label16.Text = "18.00 I 20.00";
                label18.Text = "21.00 I 23.00";
                label28.Text = "23.00 I 01.00";
            }
            //yalova

            if (label10.Text == "Yenikapı  ->  Yalova")
            {

            
                    button6.Text = (150 * s1).ToString();
                    button7.Text = (150 * s1).ToString();
                    button8.Text = (150 * s1).ToString() ;
                    button9.Text = (150 * s1).ToString() ;
                    button10.Text = (150 * s1).ToString() ;
                
                
                if(label21.Text== "Engelli")
                { 
                    button6.Text = (150 * s1 - 30).ToString();
                    button7.Text = (150 * s1 -30).ToString() ;
                    button8.Text = (150 * s1 -30).ToString()  ;
                    button9.Text = (150 * s1 -30).ToString() ;
                    button10.Text = (150 * s1 -30).ToString();
                }
                if(label21.Text == "65 Yas Üstü")
                {
                    button6.Text = (150 * s1 - 30).ToString();
                    button7.Text = (150 * s1 - 30).ToString();
                    button8.Text = (150 * s1 - 30).ToString();
                    button9.Text = (150 * s1 - 30).ToString();
                    button10.Text = (150 * s1 - 30).ToString();
                }
                if (label21.Text == "Ogrenci")
                {
                    button6.Text = (150 * s1 - 30).ToString();
                    button7.Text = (150 * s1 - 30).ToString();
                    button8.Text = (150 * s1 - 30).ToString();
                    button9.Text = (150 * s1 - 30).ToString();
                    button10.Text = (150 * s1 - 30).ToString();
                }

                label13.Text = "09.00 I 10.00";
                label14.Text = "11.00 I 12.00";
                label16.Text = "15.00 I 16.00";
                label18.Text = "18.00 I 19.00";
                label28.Text = "21.00 I 22.00";
            }
            if (label10.Text == "Yalova  ->  Yenikapı")
            {
                button6.Text = (150 * s1).ToString();
                button7.Text = (150 * s1).ToString();
                button8.Text = (150 * s1).ToString();
                button9.Text = (150 * s1).ToString();
                button10.Text = (150 * s1).ToString();
                if (label21.Text == "Engelli")
                {
                    button6.Text = (150 * s1 - 30).ToString();
                    button7.Text = (150 * s1 - 30).ToString();
                    button8.Text = (150 * s1 - 30).ToString();
                    button9.Text = (150 * s1 - 30).ToString();
                    button10.Text = (150 * s1 - 30).ToString();
                }
                if (label21.Text == "65 Yas Üstü")
                {
                    button6.Text = (150 * s1 - 30).ToString();
                    button7.Text = (150 * s1 - 30).ToString();
                    button8.Text = (150 * s1 - 30).ToString();
                    button9.Text = (150 * s1 - 30).ToString();
                    button10.Text = (150 * s1 - 30).ToString();
                }
                if (label21.Text == "Ogrenci")
                {
                    button6.Text = (150 * s1 - 30).ToString();
                    button7.Text = (150 * s1 - 30).ToString();
                    button8.Text = (150 * s1 - 30).ToString();
                    button9.Text = (150 * s1 - 30).ToString();
                    button10.Text = (150 * s1 - 30).ToString();
                }
                label13.Text = "08.00 I 09.00";
                label14.Text = "11.00 I 12.00";
                label16.Text = "14.00 I 15.00";
                label18.Text = "18.00 I 19.00";
                label28.Text = "22.00 I 23.00";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KisilerBilgiler kb = new KisilerBilgiler();
            kb.rota = label10.Text;
            kb.tarih = label1.Text;
            kb.yolcutipi = label21.Text;
            kb.yolcusayısı = label6.Text;
            kb.kalkısvarıs = label13.Text;
            kb.ucret = button6.Text;



            kb.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KisilerBilgiler kb = new KisilerBilgiler();
            kb.rota = label10.Text;
            kb.tarih = label1.Text;
            kb.yolcutipi = label21.Text;
            kb.yolcusayısı = label6.Text;
            kb.kalkısvarıs = label13.Text;
            kb.ucret = button7.Text;



            kb.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KisilerBilgiler kb = new KisilerBilgiler();
            kb.rota = label10.Text;
            kb.tarih = label1.Text;
            kb.yolcutipi = label21.Text;
            kb.yolcusayısı = label6.Text;
            kb.kalkısvarıs = label13.Text;
            kb.ucret = button8.Text;



            kb.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KisilerBilgiler kb = new KisilerBilgiler();
            kb.rota = label10.Text;
            kb.tarih = label1.Text;
            kb.yolcutipi = label21.Text;
            kb.yolcusayısı = label6.Text;
            kb.kalkısvarıs = label13.Text;
            kb.ucret = button9.Text;



            kb.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KisilerBilgiler kb = new KisilerBilgiler();
            kb.rota = label10.Text;
            kb.tarih = label1.Text;
            kb.yolcutipi = label21.Text;
            kb.yolcusayısı = label6.Text;
            kb.kalkısvarıs = label13.Text;
            kb.ucret = button10.Text;



            kb.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            ARAL_MİLES_Giriş milesgiris = new ARAL_MİLES_Giriş();
            milesgiris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferSaatleri sefersaatleri = new SeferSaatleri();
            sefersaatleri.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Biletlerim blt = new Biletlerim();
            blt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kurumsal krmsl = new Kurumsal();
            krmsl.Show();
            this.Hide();
        }
    }
}
