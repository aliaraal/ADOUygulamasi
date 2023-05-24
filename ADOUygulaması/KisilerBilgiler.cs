using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADOUygulaması
{
    public partial class KisilerBilgiler : Form
    {

        public string rota;
        public string tarih;
        public string yolcutipi;
        public string yolcusayısı;
        public string kalkısvarıs;
        public string ucret;
        public string koltukno1;
        public string koltukno2;
        public string kisisayi;

        public KisilerBilgiler()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ADODuyurular;Integrated Security=True");

        private void KisilerBilgiler_Load(object sender, EventArgs e)
        {
            label10.Text = rota;
            label11.Text = tarih;
            label14.Text = yolcutipi;
            label17.Text = yolcusayısı;
            label12.Text = kalkısvarıs;
            label48.Text = ucret;


            label9.Text = koltukno1;
            label22.Text = koltukno2;





            if (label17.Text == "1")
            {


                tabControl1.TabPages.Remove(tabPage5);
            }
            if (label17.Text == "2")
            {


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSecimi koltuksecimi = new KoltukSecimi();



            koltuksecimi.rota = label10.Text;
            koltuksecimi.tarih = label11.Text;
            koltuksecimi.yolcutipi = label14.Text;
            koltuksecimi.yolcusayısı = label17.Text;
            koltuksecimi.kalkısvarıs = label12.Text;
            koltuksecimi.ucrett = label48.Text;
            koltuksecimi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 191);
            label9.Text = sayi.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 191);
            label22.Text = sayi.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            KoltukSecimi koltuksecimi = new KoltukSecimi();
            koltuksecimi.Show();
        }

        private void button194_Click(object sender, EventArgs e)
        {
            OdemeSayfası os = new OdemeSayfası();



            os.odeme = label48.Text;
            os.adsoyad = textBox16.Text;
            os.soyad = textBox15.Text;
            os.rota = label10.Text;
            os.tarih = label11.Text;
            os.kalkısvarıs = label12.Text;
            os.koltukno = label9.Text;
            os.yolcutipi = label14.Text;
            os.aad = textBox4.Text;
            os.ssoyad = textBox3.Text;
            os.koltukno2 = label22.Text;
            os.Show();
            this.Hide();


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KişiselBilgiler ([1.Yolcu Adı],[1.Yolcu Soyadı],[1.Yolcu Telefon],[1.Yolcu TC],[1.Yolcu Cinsiyet],[1.Yolcu E-Posta],[2.Yolcu Adı],[2.Yolcu Soyadı],[2.Yolcu TC],[2.Yolcu Cinsiyet],[2.Yolcu E-Posta],[2.Yolcu Telefon]) values ('" + textBox16.Text + "','" + textBox15.Text + "','" + maskedTextBox4.Text.ToString() + "','" + textBox14.Text + "','" + comboBox1.Text + "','" + textBox13.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + maskedTextBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int sonuc;
            int sayi1 = Convert.ToInt32(label48.Text);
            if (checkBox4.Checked == true)
            {

                sonuc = sayi1 + 9;
                label48.Text = sonuc.ToString();
            }
            else
            {
                sonuc = sayi1 - 9;
                label48.Text = sonuc.ToString();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            int sonuc;
            int sayi1 = Convert.ToInt32(label48.Text);
            if (checkBox4.Checked == true)
            {

                sonuc = sayi1 + 9;
                label48.Text = sonuc.ToString();
            }
            else
            {
                sonuc = sayi1 - 9;
                label48.Text = sonuc.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kurumsal krmsl = new Kurumsal();
            krmsl.Show();
            this.Hide();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            ARAL_MİLES_Giriş milesgiris = new ARAL_MİLES_Giriş();
            milesgiris.Show();
        }
    }
}
