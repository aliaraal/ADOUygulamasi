using System;
using System.Windows.Forms;

namespace ADOUygulaması
{
    public partial class OdemeSayfası : Form
    {

        public string rota;
        public string tarih;
        public string yolcutipi;
        public string yolcusayısı;
        public string kalkısvarıs;
        public string adsoyad;
        public string koltukno;
        public string soyad;
        public string aad;
        public string ssoyad;
        public string koltukno2;


        public string odeme;
        public OdemeSayfası()
        {
            InitializeComponent();
        }

        private void OdemeSayfası_Load(object sender, EventArgs e)
        {
            label12.Text = odeme;
            label21.Text = rota;
            label19.Text = tarih;
            label18.Text = kalkısvarıs;
            textBox16.Text = adsoyad;
            label25.Text = koltukno;
            label28.Text = yolcutipi;
            textBox15.Text = soyad;

            textBox3.Text= aad;
            textBox4.Text= ssoyad;
            label32.Text = koltukno2;


        }

        private void button5_Click(object sender, EventArgs e)
        {



            BiletiGörüntüle kb = new BiletiGörüntüle();
            kb.yolcuad = textBox16.Text;
            kb.yolcusoyad = textBox15.Text;
            kb.rota = label21.Text;
            kb.tarih = label19.Text;
            kb.kalkısvarıs = label18.Text;
            kb.koltukno = label25.Text;
            kb.yolcutipi = label28.Text;
            kb.ucret = label12.Text;


            kb.aad = textBox3.Text;
            kb.ssoyad = textBox4.Text;
            kb.kno = label32.Text;








            kb.Show();
            BasarılıOdeme bo = new BasarılıOdeme();
            bo.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                button5.Enabled = true;

            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "ARALAS")
            {
                int sonuc;
                int sayi1 = Convert.ToInt32(label12.Text);
                sonuc = sayi1 - 20;
                label12.Text = sonuc.ToString();
            }
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
