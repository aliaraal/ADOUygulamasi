using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ADOUygulaması
{
    public partial class BiletiGörüntüle : Form
    {

        public string yolcuad;
        public string yolcusoyad;
        public string rota;
        public string kalkısvarıs;
        public string koltukno;
        public string tarih;
        public string yolcutipi;
        public string ucret;
        public string aad;
        public string ssoyad;
        public string kno;

        public BiletiGörüntüle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ADODuyurular;Integrated Security=True");

        private void BiletiGörüntüle_Load(object sender, EventArgs e)
        {
            //1
            label1.Text = yolcuad;
            label18.Text = yolcusoyad;
            label3.Text = tarih;
            label5.Text = rota;
            label6.Text = kalkısvarıs;
            label7.Text = koltukno;
            label8.Text = yolcutipi;
            

            label9.Text = yolcuad;
            label17.Text = yolcusoyad;
            label10.Text = tarih;
                label11.Text = rota;
            label12.Text = kalkısvarıs;
            label14.Text = koltukno;
            label15.Text = yolcutipi;
            label16.Text = ucret;

            //2
            label33.Text = aad;
            label19.Text = ssoyad;
            label32.Text = tarih;
            label31.Text = rota;
            label30.Text = kalkısvarıs;
            label29.Text = kno;
            label28.Text = yolcutipi;


            label27.Text = aad;
            label20.Text = ssoyad;
            label26.Text = tarih;
            label25.Text = rota;
            label24.Text = kalkısvarıs;
            label23.Text = kno;
            label22.Text = yolcutipi;
            label21.Text = ucret;


            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://busclub.epizy.com/", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
           pictureBox2.Image=qrCodeImage;
            pictureBox5.Image = qrCodeImage;

            Zen.Barcode.Code128BarcodeDraw brc =  Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox3.Image = brc.Draw("1234567890", 35);
            pictureBox4.Image = brc.Draw("1234567890", 36);

            if(label33.Text== "Adınız")
            {
                pictureBox6.Visible=false;
                label33.Visible = false;
                label19.Visible = false;
                label32.Visible = false;
                label31.Visible = false;
                label30.Visible = false;
                label29.Visible = false;
                label28.Visible = false;
                label27.Visible = false;
                label26.Visible = false;
                label25.Visible = false;
                label24.Visible = false;
                label23.Visible = false;
                label22.Visible = false;
                label21.Visible = false;
                label20.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;

            }
            else{
                pictureBox6.Visible = true;
                pictureBox6.Visible = true;
                label33.Visible = true;
                label19.Visible = true;
                label32.Visible = true;
                label31.Visible = true;
                label30.Visible = true;
                label29.Visible = true;
                label28.Visible = true;
                label27.Visible = true;
                label26.Visible = true;
                label25.Visible = true;
                label24.Visible = true;
                label23.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                label20.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into BiletBilgileri (Adı,Soyadı,Rota,Saat,KoltukNo,Kategorı,Ucret,Tarih,[2.Adı],[2.Soyadı])values ('" + label1.Text + "','" + label18.Text + "','" + label5.Text + "','" + label6.Text + "','" + label7.Text + "','" + label8.Text + "','" + label16.Text + "','" + label3.Text + "','"+label33.Text+"','"+label19.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

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
