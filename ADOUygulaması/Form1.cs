using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace ADOUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ADODuyurular;Integrated Security=True");


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            ARAL_MİLES_Giriş milesgiris = new ARAL_MİLES_Giriş();
            milesgiris.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


            //GIDIS

            if (comboBox4.Text == "Bandırma")  
            {

                comboBox3.Text = "NEREYE";

                comboBox3.Items.Clear();
                comboBox3.Items.Add("Yenikapı"); 
            }
            if (comboBox4.Text == "Bursa")
            {


                comboBox3.Text = "NEREYE";
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Yenikapı");
            }
            if (comboBox4.Text == "Yalova")
            {

                comboBox3.Text = "NEREYE";

                comboBox3.Items.Clear();
                comboBox3.Items.Add("Yenikapı");
            }
            if (comboBox4.Text == "Yenikapı")
            {

                comboBox3.Text = "NEREYE";

                comboBox3.Items.Clear();
                comboBox3.Items.Add("Yalova");
                comboBox3.Items.Add("Bursa");
                comboBox3.Items.Add("Bandırma");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;





        }


        

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {

            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GİDİS DONUS

            if (comboBox6.Text == "Bandırma")
            {

                comboBox5.Text = "NEREYE";

                comboBox5.Items.Clear();
                comboBox5.Items.Add("Yenikapı");
            }
            if (comboBox6.Text == "Bursa")
            {


                comboBox5.Text = "NEREYE";
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Yenikapı");
            }
            if (comboBox6.Text == "Yalova")
            {

                comboBox5.Text = "NEREYE";

                comboBox5.Items.Clear();
                comboBox5.Items.Add("Yenikapı");
            }
            if (comboBox6.Text == "Yenikapı")
            {

                comboBox5.Text = "NEREYE";

                comboBox5.Items.Clear();
                comboBox5.Items.Add("Yalova");
                comboBox5.Items.Add("Bursa");
                comboBox5.Items.Add("Bandırma");
            }

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                dateTimePicker2.Visible = true;
                comboBox2.Visible = true;
                label5.Visible = true;
                numericUpDown2.Visible = true;

            }
            else
            {
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                dateTimePicker2.Visible = false;
                comboBox2.Visible = false;
                label5.Visible = false;
                numericUpDown2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ansayfa = new Form1();
            ansayfa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {



            BiletAlmaSayfası blt = new BiletAlmaSayfası();
            blt.yazı = comboBox4.Text + "  ->  " + comboBox3.Text;
            blt.gidistarih1 = dateTimePicker1.Text;
            blt.yolcutipi1 = comboBox1.Text;
            blt.yolcuadedi1 = numericUpDown1.Text;
            blt.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = label7.Text.Substring(1) + label7.Text.Substring(0, 1);



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            Duyurular duyurular = new Duyurular();
            duyurular.Show();
            this.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 2)
            {

            }
            else
            {
                MessageBox.Show
                   ("En Fazla 2 Yolcu Seçilebilir!");
                numericUpDown1.Value = 0;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value <= 2)
            {

            }
            else
            {
                MessageBox.Show
                   ("En Fazla 2 Yolcu Seçilebilir!");
                numericUpDown2.Value = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Biletlerim blt = new Biletlerim();
            blt.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

