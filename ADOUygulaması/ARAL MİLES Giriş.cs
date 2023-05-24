using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOUygulaması
{
    public partial class ARAL_MİLES_Giriş : Form
    {
        public ARAL_MİLES_Giriş()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "admin" && textBox2.Text == "12345" &&textBox3.Text== label7.Text)
            {
                Aral_Miles arlmls = new Aral_Miles();
                arlmls.Show();
                this.Hide();
            }
            else
            { 
            }

            if (textBox1.Text != "admin" && textBox2.Text != "12345") {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifresi! Lütfen Tekrar Deneyiniz!");
                textBox1.Clear();
                textBox2.Clear();
            }

            if (textBox3.Text != label7.Text)
            {
                MessageBox.Show("LÜTFEN DOĞRULAMA KODUNU DOĞRU GİRİNİZ!");
                textBox1.Clear();
                textBox2.Clear();
            }
        
        
        }

        private void ARAL_MİLES_Giriş_Load(object sender, EventArgs e)
        {
            string karakter1;
            string[] dizi1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "W", "X" };
            int sembol1 = rastgele.Next(0, dizi1.Length);
            karakter1 = (dizi1[sembol1]);

            //2

            string karakter2;
            string[] dizi2 = {"1","2","3","4","5","6","7","8","9","0" };
            int sembol2 = rastgele.Next(0, dizi2.Length);
            karakter2 = (dizi2[sembol2]);
            //3
            string karakter3;
            string[] dizi3 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "W", "X" };
            int sembol3 = rastgele.Next(0, dizi3.Length);
            karakter3 = (dizi3[sembol3]);

            //4

            string karakter4;
            string[] dizi4 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int sembol4 = rastgele.Next(0, dizi2.Length);
            karakter4 = (dizi4[sembol4]);
            label7.Text = karakter4.ToString() + karakter2.ToString();

            label7.Text = karakter1.ToString() + karakter2.ToString() + karakter3.ToString() + karakter4.ToString();
        }
    }
}
