using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOUygulaması
{
    public partial class Biletlerim : Form
    {
        public Biletlerim()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ADODuyurular;Integrated Security=True");


        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from BiletBilgileri", baglanti);
            SqlDataReader oku=komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Adı"].ToString();
                ekle.SubItems.Add(oku["Soyadı"].ToString());
                ekle.SubItems.Add(oku["Rota"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Kategorı"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["2.Adı"].ToString());
                ekle.SubItems.Add(oku["2.Soyadı"].ToString());


                listView1.Items.Add(ekle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = (listView1.SelectedItems[0].SubItems[0].Text);
            label18.Text = listView1.SelectedItems[0].SubItems[1].Text;
            label5.Text = listView1.SelectedItems[0].SubItems[2].Text;
            label6.Text = listView1.SelectedItems[0].SubItems[3].Text;
            label7.Text = listView1.SelectedItems[0].SubItems[4].Text;

            label8.Text = listView1.SelectedItems[0].SubItems[5].Text;

            label16.Text = listView1.SelectedItems[0].SubItems[6].Text;
            label3.Text = listView1.SelectedItems[0].SubItems[7].Text;
            label33.Text = listView1.SelectedItems[0].SubItems[8].Text;

            label19.Text = listView1.SelectedItems[0].SubItems[9].Text;


            label9.Text = label1.Text;
            label17.Text = label18.Text;
            label11.Text = label5.Text;
            label12.Text = label6.Text;
            label14.Text = label7.Text;
            label15.Text = label8.Text;
            label16.Text = label16.Text;
            label10.Text = label3.Text;

            label32.Text = label3.Text;

            label31.Text = label5.Text;
            label30.Text = label6.Text;
            label29.Text = label7.Text;
            label28.Text = label8.Text;
            label21.Text = label16.Text;




        }

        private void Biletlerim_Load(object sender, EventArgs e)
        {
            verilerigoster();


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
