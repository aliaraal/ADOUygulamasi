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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ADOUygulaması
{
    public partial class KoltukSecimi : Form
    {

        public string rota;
        public string tarih;
        public string yolcutipi;
        public string yolcusayısı;
        public string kalkısvarıs;
        public string ucret;
        public string kisisayi;
        public string ucrett;

        public KoltukSecimi()
        {
            InitializeComponent();
        }

        private void KoltukSecimi_Load(object sender, EventArgs e)
        {
            label10.Text = rota;
            label11.Text = tarih;
            label14.Text = yolcutipi;
            label17.Text = yolcusayısı;
            label12.Text = kalkısvarıs;
            label13.Text = ucrett;

            this.AutoScroll = true;

            KisilerBilgiler kb = new KisilerBilgiler();
            kb.yolcusayısı = label48.Text;

            if(label17.Text == "1")
            {
                label6.Visible = false;
                    label5.Visible = false;
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "1";
            }
            else
            {
                label5.Text = "1";
            }
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "2";
            }
            else
            {
                label5.Text = "2";
            }


            button40.BackColor = Color.Red;
            button40.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "3";
            }
            else
            {
                label5.Text = "3";
            }


            button41.BackColor = Color.Red;
            button41.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (label4.Text == "---")
            {
                label4.Text = "4";
            }
            else
            {
                label5.Text = "4";
            }
            button13.BackColor = Color.Red;
            button13.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "5";
            }
            else
            {
                label5.Text = "5";
            }
            button38.BackColor = Color.Red;
            button38.Enabled = false;

           
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "6";
            }
            else
            {
                label5.Text = "6";
            }
            button39.BackColor = Color.Red;
            button39.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "7";
            }
            else
            {
                label5.Text = "7";
            }
            button17.BackColor = Color.Red;
            button17.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "8";
            }
            else
            {
                label5.Text = "8";
            }
            button36.BackColor = Color.Red;
            button36.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "9";
            }
            else
            {
                label5.Text = "9";
            }
            button37.BackColor = Color.Red;
            button37.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "10";
            }
            else
            {
                label5.Text = "10";
            }
            button21.BackColor = Color.Red;
            button21.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "11";
            }
            else
            {
                label5.Text = "11";
            }
            button34.BackColor = Color.Red;
            button34.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "12";
            }
            else
            {
                label5.Text = "12";
            }
            button35.BackColor = Color.Red;
            button35.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "13";
            }
            else
            {
                label5.Text = "13";
            }
            button25.BackColor = Color.Red;
            button25.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "14";
            }
            else
            {
                label5.Text = "14";
            }
            button32.BackColor = Color.Red;
            button32.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "15";
            }
            else
            {
                label5.Text = "15";
            }
            button33.BackColor = Color.Red;
            button33.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "16";
            }
            else
            {
                label5.Text = "16";
            }
            button29.BackColor = Color.Red;
            button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "17";
            }
            else
            {
                label5.Text = "17";
            }
            button30.BackColor = Color.Red;
            button30.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "18";
            }
            else
            {
                label5.Text = "18";
            }
            button31.BackColor = Color.Red;
            button31.Enabled = false;
        }

        private void button125_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "19";
            }
            else
            {
                label5.Text = "19";
            }
            button125.BackColor = Color.Red;
            button125.Enabled = false;
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "20";
            }
            else
            {
                label5.Text = "20";
            }
            button100.BackColor = Color.Red;
            button100.Enabled = false;
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "21";
            }
            else
            {
                label5.Text = "21";
            }
            button101.BackColor = Color.Red;
            button101.Enabled = false;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "22";
            }
            else
            {
                label5.Text = "22";
            }
            button121.BackColor = Color.Red;
            button121.Enabled = false;
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "23";
            }
            else
            {
                label5.Text = "23";
            }
            button98.BackColor = Color.Red;
            button98.Enabled = false;
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "24";
            }
            else
            {
                label5.Text = "24";
            }
            button99.BackColor = Color.Red;
            button99.Enabled = false;
        }

        private void button117_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "25";
            }
            else
            {
                label5.Text = "25";
            }
            button117.BackColor = Color.Red;
            button117.Enabled = false;
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "26";
            }
            else
            {
                label5.Text = "26";
            }
            button96.BackColor = Color.Red;
            button96.Enabled = false;
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "27";
            }
            else
            {
                label5.Text = "27";
            }
            button97.BackColor = Color.Red;
            button97.Enabled = false;
        }

        private void button113_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "28";
            }
            else
            {
                label5.Text = "28";
            }
            button113.BackColor = Color.Red;
            button113.Enabled = false;
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "29";
            }
            else
            {
                label5.Text = "29";
            }
            button94.BackColor = Color.Red;
            button94.Enabled = false;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "30";
            }
            else
            {
                label5.Text = "30";
            }
            button95.BackColor = Color.Red;
            button95.Enabled = false;
        }

        private void button109_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "31";
            }
            else
            {
                label5.Text = "31";
            }
            button109.BackColor = Color.Red;
            button109.Enabled = false;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "32";
            }
            else
            {
                label5.Text = "32";
            }
            button92.BackColor = Color.Red;
            button92.Enabled = false;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "33";
            }
            else
            {
                label5.Text = "33";
            }
            button93.BackColor = Color.Red;
            button93.Enabled = false;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "34";
            }
            else
            {
                label5.Text = "34";
            }
            button105.BackColor = Color.Red;
            button105.Enabled = false;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "35";
            }
            else
            {
                label5.Text = "35";
            }
            button90.BackColor = Color.Red;
            button90.Enabled = false;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "36";
            }
            else
            {
                label5.Text = "36";
            }
            button91.BackColor = Color.Red;
            button91.Enabled = false;
        }

        private void button127_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "37";
            }
            else
            {
                label5.Text = "37";
            }
            button127.BackColor = Color.Red;
            button127.Enabled = false;
        }

        private void button129_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "38";
            }
            else
            {
                label5.Text = "38";
            }
            button129.BackColor = Color.Red;
            button129.Enabled = false;
        }

        private void button128_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "39";
            }
            else
            {
                label5.Text = "39";
            }
            button128.BackColor = Color.Red;
            button128.Enabled = false;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "40";
            }
            else
            {
                label5.Text = "40";
            }
            button88.BackColor = Color.Red;
            button88.Enabled = false;
        }

        private void button126_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "41";
            }
            else
            {
                label5.Text = "41";
            }
            button126.BackColor = Color.Red;
            button126.Enabled = false;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "42";
            }
            else
            {
                label5.Text = "42";
            }
            button89.BackColor = Color.Red;
            button89.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "43";
            }
            else
            {
                label5.Text = "43";
            }
            button2.BackColor = Color.Red;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "44";
            }
            else
            {
                label5.Text = "44";
            }
            button3.BackColor = Color.Red;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "45";
            }
            else
            {
                label5.Text = "45";
            }
            button4.BackColor = Color.Red;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "46";
            }
            else
            {
                label5.Text = "46";
            }
            button5.BackColor = Color.Red;
            button5.Enabled = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "47";
            }
            else
            {
                label5.Text = "47";
            }
            button59.BackColor = Color.Red;
            button59.Enabled = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "48";
            }
            else
            {
                label5.Text = "48";
            }
            button52.BackColor = Color.Red;
            button52.Enabled = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "49";
            }
            else
            {
                label5.Text = "49";
            }
            button53.BackColor = Color.Red;
            button53.Enabled = false;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "50";
            }
            else
            {
                label5.Text = "50";
            }
            button65.BackColor = Color.Red;
            button65.Enabled = false;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "51";
            }
            else
            {
                label5.Text = "51";
            }
            button58.BackColor = Color.Red;
            button58.Enabled = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "52";
            }
            else
            {
                label5.Text = "52";
            }
            button50.BackColor = Color.Red;
            button50.Enabled = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "53";
            }
            else
            {
                label5.Text = "53";
            }
            button51.BackColor = Color.Red;
            button51.Enabled = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "54";
            }
            else
            {
                label5.Text = "54";
            }
            button64.BackColor = Color.Red;
            button64.Enabled = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "55";
            }
            else
            {
                label5.Text = "55";
            }
            button57.BackColor = Color.Red;
            button57.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "56";
            }
            else
            {
                label5.Text = "56";
            }
            button48.BackColor = Color.Red;
            button48.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "57";
            }
            else
            {
                label5.Text = "57";
            }
            button49.BackColor = Color.Red;
            button49.Enabled = false;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "58";
            }
            else
            {
                label5.Text = "58";
            }
            button63.BackColor = Color.Red;
            button63.Enabled = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "59";
            }
            else
            {
                label5.Text = "59";
            }
            button56.BackColor = Color.Red;
            button56.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "60";
            }
            else
            {
                label5.Text = "60";
            }
            button46.BackColor = Color.Red;
            button46.Enabled = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "61";
            }
            else
            {
                label5.Text = "61";
            }
            button47.BackColor = Color.Red;
            button47.Enabled = false;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "62";
            }
            else
            {
                label5.Text = "62";
            }
            button62.BackColor = Color.Red;
            button62.Enabled = false;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "63";
            }
            else
            {
                label5.Text = "63";
            }
            button55.BackColor = Color.Red;
           button55.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "64";
            }
            else
            { 
                label5.Text = "64";
            }
            button44.BackColor = Color.Red;
            button44.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "65";
            }
            else
            {
                label5.Text = "65";
            }
            button45.BackColor = Color.Red;
            button45.Enabled = false;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "66";
            }
            else
            {
                label5.Text = "66";
            }
            button61.BackColor = Color.Red;
            button61.Enabled = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "67";
            }
            else
            {
                label5.Text = "67";
            }
            button54.BackColor = Color.Red;
            button54.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "68";
            }
            else
            {
                label5.Text = "68";
            }
            button42.BackColor = Color.Red;
            button42.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "69";
            }
            else
            {
                label5.Text = "69";
            }
            button43.BackColor = Color.Red;
            button43.Enabled = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "70";
            }
            else
            {
                label5.Text = "70";
            }
            button60.BackColor = Color.Red;
            button60.Enabled = false;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "71";
            }
            else
            {
                label5.Text = "71";
            }
            button87.BackColor = Color.Red;
            button87.Enabled = false;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "72";
            }
            else
            {
                label5.Text = "72";
            }
            button78.BackColor = Color.Red;
            button78.Enabled = false;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "73";
            }
            else
            {
                label5.Text = "73";
            }
            button79.BackColor = Color.Red;
            button79.Enabled = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "74";
            }
            else
            {
                label5.Text = "74";
            }
            button69.BackColor = Color.Red;
            button69.Enabled = false;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "75";
            }
            else
            {
                label5.Text = "75";
            }
            button86.BackColor = Color.Red;
            button86.Enabled = false;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "76";
            }
            else
            {
                label5.Text = "76";
            }
            button76.BackColor = Color.Red;
            button76.Enabled = false;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "77";
            }
            else
            {
                label5.Text = "77";
            }
            button77.BackColor = Color.Red;
            button77.Enabled = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "78";
            }
            else
            {
                label5.Text = "78";
            }
            button68.BackColor = Color.Red;
            button68.Enabled = false;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "79";
            }
            else
            {
                label5.Text = "79";
            }
            button85.BackColor = Color.Red;
            button85.Enabled = false;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "80";
            }
            else
            {
                label5.Text = "80";
            }
            button74.BackColor = Color.Red;
            button74.Enabled = false;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "81";
            }
            else
            {
                label5.Text = "81";
            }
            button75.BackColor = Color.Red;
            button75.Enabled = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "82";
            }
            else
            {
                label5.Text = "82";
            }
            button67.BackColor = Color.Red;
            button67.Enabled = false;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "83";
            }
            else
            {
                label5.Text = "83";
            }
            button84.BackColor = Color.Red;
            button84.Enabled = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "84";
            }
            else
            {
                label5.Text = "84";
            }
            button72.BackColor = Color.Red;
            button72.Enabled = false;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "85";
            }
            else
            {
                label5.Text = "85";
            }
            button73.BackColor = Color.Red;
            button73.Enabled = false;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "86";
            }
            else
            {
                label5.Text = "86";
            }
            button66.BackColor = Color.Red;
            button66.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "87";
            }
            else
            {
                label5.Text = "87";
            }
            button8.BackColor = Color.Red;
            button8.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "88";
            }
            else
            {
                label5.Text = "88";
            }
            button6.BackColor = Color.Red;
            button6.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "89";
            }
            else
            {
                label5.Text = "89";
            }
            button9.BackColor = Color.Red;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "90";
            }
            else
            {
                label5.Text = "90";
            }
            button10.BackColor = Color.Red;
            button10.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "91";
            }
            else
            {
                label5.Text = "91";
            }
            button12.BackColor = Color.Red;
            button12.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "92";
            }
            else
            {
                label5.Text = "92";
            }
            button11.BackColor = Color.Red;
            button11.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "93";
            }
            else
            {
                label5.Text = "93";
            }
            button14.BackColor = Color.Red;
            button14.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "94";
            }
            else
            {
                label5.Text = "94";
            }
            button16.BackColor = Color.Red;
            button16.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "95";
            }
            else
            {
                label5.Text = "95";
            }
            button15.BackColor = Color.Red;
            button15.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "96";
            }
            else
            {
                label5.Text = "96";
            }
            button18.BackColor = Color.Red;
            button18.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "97";
            }
            else
            {
                label5.Text = "97";
            }
            button20.BackColor = Color.Red;
            button20.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "98";
            }
            else
            {
                label5.Text = "98";
            }
            button19.BackColor = Color.Red;
            button19.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "99";
            }
            else
            {
                label5.Text = "99";
            }
            button22.BackColor = Color.Red;
            button22.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "100";
            }
            else
            {
                label5.Text = "100";
            }
            button24.BackColor = Color.Red;
            button24.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "101";
            }
            else
            {
                label5.Text = "101";
            }
            button23.BackColor = Color.Red;
            button23.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "102";
            }
            else
            {
                label5.Text = "102";
            }
            button26.BackColor = Color.Red;
            button26.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "103";
            }
            else
            {
                label5.Text = "103";
            }
            button28.BackColor = Color.Red;
            button28.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "104";
            }
            else
            {
                label5.Text = "104";
            }
            button27.BackColor = Color.Red;
            button27.Enabled = false;
        }

        private void button122_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "105";
            }
            else
            {
                label5.Text = "105";
            }
            button122.BackColor = Color.Red;
            button122.Enabled = false;
        }

        private void button124_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "106";
            }
            else
            {
                label5.Text = "106";
            }
            button124.BackColor = Color.Red;
            button124.Enabled = false;
        }

        private void button123_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "107";
            }
            else
            {
                label5.Text = "107";
            }
            button123.BackColor = Color.Red;
            button123.Enabled = false;
        }

        private void button118_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "108";
            }
            else
            {
                label5.Text = "108";
            }
            button118.BackColor = Color.Red;
            button118.Enabled = false;
        }

        private void button120_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "109";
            }
            else
            {
                label5.Text = "109";
            }
            button120.BackColor = Color.Red;
            button120.Enabled = false;
        }

        private void button119_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "110";
            }
            else
            {
                label5.Text = "110";
            }
            button119.BackColor = Color.Red;
            button119.Enabled = false;
        }

        private void button114_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "111";
            }
            else
            {
                label5.Text = "111";
            }
            button114.BackColor = Color.Red;
            button114.Enabled = false;
        }

        private void button116_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "112";
            }
            else
            {
                label5.Text = "112";
            }
            button116.BackColor = Color.Red;
            button116.Enabled = false;
        }

        private void button115_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "113";
            }
            else
            {
                label5.Text = "113";
            }
            button115.BackColor = Color.Red;
            button115.Enabled = false;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "114";
            }
            else
            {
                label5.Text = "114";
            }
            button110.BackColor = Color.Red;
            button110.Enabled = false;
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "115";
            }
            else
            {
                label5.Text = "115";
            }
            button112.BackColor = Color.Red;
            button112.Enabled = false;
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "116";
            }
            else
            {
                label5.Text = "116";
            }
            button111.BackColor = Color.Red;
            button111.Enabled = false;
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "117";
            }
            else
            {
                label5.Text = "117";
            }
            button106.BackColor = Color.Red;
            button106.Enabled = false;
        }

        private void button108_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "118";
            }
            else
            {
                label5.Text = "118";
            }
            button108.BackColor = Color.Red;
            button108.Enabled = false;
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "119";
            }
            else
            {
                label5.Text = "119";
            }
            button107.BackColor = Color.Red;
            button107.Enabled = false;
        }

        private void button102_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "120";
            }
            else
            {
                label5.Text = "120";
            }
            button102.BackColor = Color.Red;
            button102.Enabled = false;
        }

        private void button104_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "121";
            }
            else
            {
                label5.Text = "121";
            }
            button104.BackColor = Color.Red;
            button104.Enabled = false;
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "122";
            }
            else
            {
                label5.Text = "122";
            }
            button103.BackColor = Color.Red;
            button103.Enabled = false;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "123";
            }
            else
            {
                label5.Text = "123";
            }
            button81.BackColor = Color.Red;
            button81.Enabled = false;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "124";
            }
            else
            {
                label5.Text = "124";
            }
            button83.BackColor = Color.Red;
            button83.Enabled = false;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "125";
            }
            else
            {
                label5.Text = "125";
            }
            button82.BackColor = Color.Red;
            button82.Enabled = false;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "126";
            }
            else
            {
                label5.Text = "126";
            }
            button70.BackColor = Color.Red;
            button70.Enabled = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "127";
            }
            else
            {
                label5.Text = "127";
            }
            button80.BackColor = Color.Red;
            button80.Enabled = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "128";
            }
            else
            {
                label5.Text = "128";
            }
            button71.BackColor = Color.Red;
            button71.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button149_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "129";
            }
            else
            {
                label5.Text = "129";
            }
            button149.BackColor = Color.Red;
            button149.Enabled = false;
        }

        private void button142_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "130";
            }
            else
            {
                label5.Text = "130";
            }
            button142.BackColor = Color.Red;
            button142.Enabled = false;
        }

        private void button143_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "131";
            }
            else
            {
                label5.Text = "131";
            }
            button143.BackColor = Color.Red;
            button143.Enabled = false;
        }

        private void button148_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "132";
            }
            else
            {
                label5.Text = "132";
            }
            button148.BackColor = Color.Red;
            button148.Enabled = false;
        }

        private void button140_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "133";
            }
            else
            {
                label5.Text = "133";
            }
            button140.BackColor = Color.Red;
            button140.Enabled = false;
        }

        private void button141_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "134";
            }
            else
            {
                label5.Text = "134";
            }
            button141.BackColor = Color.Red;
            button141.Enabled = false;
        }

        private void button147_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "135";
            }
            else
            {
                label5.Text = "135";
            }
            button147.BackColor = Color.Red;
            button147.Enabled = false;
        }

        private void button138_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "136";
            }
            else
            {
                label5.Text = "136";
            }
            button138.BackColor = Color.Red;
            button138.Enabled = false;
        }

        private void button139_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "137";
            }
            else
            {
                label5.Text = "137";
            }
            button139.BackColor = Color.Red;
            button139.Enabled = false;
        }

        private void button146_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "138";
            }
            else
            {
                label5.Text = "138";
            }
            button146.BackColor = Color.Red;
            button146.Enabled = false;
        }

        private void button136_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "139";
            }
            else
            {
                label5.Text = "139";
            }
            button136.BackColor = Color.Red;
            button136.Enabled = false;
        }

        private void button137_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "140";
            }
            else
            {
                label5.Text = "140";
            }
            button137.BackColor = Color.Red;
            button137.Enabled = false;
        }

        private void button145_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "141";
            }
            else
            {
                label5.Text = "141";
            }
            button145.BackColor = Color.Red;
            button145.Enabled = false;
        }

        private void button134_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "142";
            }
            else
            {
                label5.Text = "142";
            }
            button134.BackColor = Color.Red;
            button134.Enabled = false;
        }

        private void button135_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "143";
            }
            else
            {
                label5.Text = "143";
            }
            button135.BackColor = Color.Red;
            button135.Enabled = false;
        }

        private void button144_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "144";
            }
            else
            {
                label5.Text = "144";
            }
            button144.BackColor = Color.Red;
            button144.Enabled= false;
        }

        private void button132_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "145";
            }
            else
            {
                label5.Text = "145";
            }
            button132.BackColor = Color.Red;
            button132.Enabled = false;
        }

        private void button133_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "146";
            }
            else
            {
                label5.Text = "146";
            }
            button133.BackColor = Color.Red;
            button133.Enabled = false;
        }

        private void button174_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "147";
            }
            else
            {
                label5.Text = "147";
            }
            button174.BackColor = Color.Red;
            button174.Enabled = false;
        }

        private void button175_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "148";
            }
            else
            {
                label5.Text = "148";
            }
            button175.BackColor = Color.Red;
            button175.Enabled = false;
        }

        private void button176_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "149";
            }
            else
            {
                label5.Text = "149";
            }
            button176.BackColor = Color.Red;
            button176.Enabled = false;
        }

        private void button177_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "150";
            }
            else
            {
                label5.Text = "150";
            }
            button177.BackColor = Color.Red;
            button177.Enabled = false;
        }

        private void button173_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "151";
            }
            else
            {
                label5.Text = "151";
            }
            button173.BackColor = Color.Red;
            button173.Enabled = false;
        }

        private void button170_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "152";
            }
            else
            {
                label5.Text = "152";
            }
            button170.BackColor = Color.Red;
            button170.Enabled = false;
        }

        private void button171_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "153";
            }
            else
            {
                label5.Text = "153";
            }
            button171.BackColor = Color.Red;
            button171.Enabled = false;
        }

        private void button172_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "154";
            }
            else
            {
                label5.Text = "154";
            }
            button172.BackColor = Color.Red;
            button172.Enabled = false;
        }

        private void button168_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "155";
            }
            else
            {
                label5.Text = "155";
            }
            button168.BackColor = Color.Red;
            button168.Enabled = false;
        }

        private void button169_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "156";
            }
            else
            {
                label5.Text = "156";
            }
            button169.BackColor = Color.Red;
            button169.Enabled = false;
        }

        private void button187_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "157";
            }
            else
            {
                label5.Text = "157";
            }
            button187.BackColor = Color.Red;
            button187.Enabled = false;
        }

        private void button185_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "158";
            }
            else
            {
                label5.Text = "158";
            }
            button185.BackColor = Color.Red;
            button185.Enabled = false;
        }

        private void button186_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "159";
            }
            else
            {
                label5.Text = "159";
            }
            button186.BackColor = Color.Red;
            button186.Enabled = false;
        }

        private void button167_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "160";
            }
            else
            {
                label5.Text = "160";
            }
            button167.BackColor = Color.Red;
            button167.Enabled = false;
        }

        private void button160_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "161";
            }
            else
            {
                label5.Text = "161";
            }
            button160.BackColor = Color.Red;
            button160.Enabled = false;
        }

        private void button161_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "162";
            }
            else
            {
                label5.Text = "162";
            }
            button161.BackColor = Color.Red;
            button161.Enabled = false;
        }

        private void button166_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "163";
            }
            else
            {
                label5.Text = "163";
            }
            button166.BackColor = Color.Red;
            button166.Enabled = false;
        }

        private void button158_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "164";
            }
            else
            {
                label5.Text = "164";
            }
            button158.BackColor = Color.Red;
            button158.Enabled = false;
        }

        private void button159_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "165";
            }
            else
            {
                label5.Text = "165";
            }
            button159.BackColor = Color.Red;
            button159.Enabled = false;
        }

        private void button165_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "166";
            }
            else
            {
                label5.Text = "166";
            }
            button165.BackColor = Color.Red;
            button165.Enabled = false;
        }

        private void button156_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "167";
            }
            else
            {
                label5.Text = "167";
            }
            button156.BackColor = Color.Red;
            button156.Enabled = false;
        }

        private void button157_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "168";
            }
            else
            {
                label5.Text = "168";
            }
            button157.BackColor = Color.Red;
            button157.Enabled = false;
        }

        private void button164_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "169";
            }
            else
            {
                label5.Text = "169";
            }
            button164.BackColor = Color.Red;
            button164.Enabled = false;
        }

        private void button154_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "170";
            }
            else
            {
                label5.Text = "170";
            }
            button154.BackColor = Color.Red;
            button154.Enabled = false;
        }

        private void button155_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "171";
            }
            else
            {
                label5.Text = "171";
            }
            button155.BackColor = Color.Red;
            button155.Enabled = false;
        }

        private void button163_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "172";
            }
            else
            {
                label5.Text = "172";
            }
            button163.BackColor = Color.Red;
            button163.Enabled = false;
        }

        private void button152_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "173";
            }
            else
            {
                label5.Text = "173";
            }
            button152.BackColor = Color.Red;
            button152.Enabled = false;
        }

        private void button153_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "174";
            }
            else
            {
                label5.Text = "174";
            }
            button153.BackColor = Color.Red;
            button153.Enabled = false;
        }

        private void button162_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "175";
            }
            else
            {
                label5.Text = "175";
            }
            button162.BackColor = Color.Red;
            button162.Enabled = false;
        }

        private void button150_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "176";
            }
            else
            {
                label5.Text = "176";
            }
            button150.BackColor = Color.Red;
            button150.Enabled = false;
        }

        private void button151_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "177";
            }
            else
            {
                label5.Text = "177";
            }
            button151.BackColor = Color.Red;
            button151.Enabled = false;
        }

        private void button180_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "178";
            }
            else
            {
                label5.Text = "178";
            }
            button180.BackColor = Color.Red;
            button180.Enabled = false;
        }

        private void button181_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "179";
            }
            else
            {
                label5.Text = "179";
            }
            button181.BackColor = Color.Red;
            button181.Enabled = false;
        }

        private void button178_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "180";
            }
            else
            {
                label5.Text = "180";
            }
            button178.BackColor = Color.Red;
            button178.Enabled = false;
        }

        private void button179_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "181";
            }
            else
            {
                label5.Text = "181";
            }
            button179.BackColor = Color.Red;
            button179.Enabled = false;
        }

        private void button183_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "182";
            }
            else
            {
                label5.Text = "182";
            }
            button183.BackColor = Color.Red;
            button183.Enabled = false;
        }

        private void button190_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "183";
            }
            else
            {
                label5.Text = "183";
            }
            button190.BackColor = Color.Red;
            button190.Enabled = false;
        }

        private void button188_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "184";
            }
            else
            {
                label5.Text = "184";
            }
            button188.BackColor = Color.Red;
            button188.Enabled = false;
        }

        private void button189_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "185";
            }
            else
            {
                label5.Text = "185";
            }
            button189.BackColor = Color.Red;
            button189.Enabled = false;
        }

        private void button184_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "186";
            }
            else
            {
                label5.Text = "186";
            }
            button184.BackColor = Color.Red;
            button184.Enabled = false;
        }

        private void button182_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "187";
            }
            else
            {
                label5.Text = "187";
            }
            button182.BackColor = Color.Red;
            button182.Enabled = false;
        }

        private void button193_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "188";
            }
            else
            {
                label5.Text = "188";
            }
            button193.BackColor = Color.Red;
            button193.Enabled = false;
        }

        private void button191_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "189";
            }
            else
            {
                label5.Text = "189";
            }
            button191.BackColor = Color.Red;
            button191.Enabled = false;
        }

        private void button192_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "190";
            }
            else
            {
                label5.Text = "190";
                
            }


            button192.BackColor = Color.Red;
            button192.Enabled = false;
        }

        private void button199_Click(object sender, EventArgs e)
        {
            if (label4.Text == "---")
            {
                label4.Text = "191";
            }
            else
            {
                label5.Text = "191";

            }
            if(label5.Text != "---")
            {
                button199.Enabled = false;
            }
            button199.BackColor = Color.Red;
            button199.Enabled = false;
        }

        private void button194_Click(object sender, EventArgs e)
        {
            KisilerBilgiler kb = new KisilerBilgiler();
            kb.koltukno1 = label4.Text;
            kb.koltukno2=label5.Text;
            kb.rota = label10.Text;
            kb.tarih = label11.Text;
            kb.yolcutipi = label14.Text;
            kb.yolcusayısı = label17.Text;
            kb.kalkısvarıs = label12.Text;
            kb.ucret = label13.Text;
            kb.Show();
            this.Hide();
        }
    }
}
