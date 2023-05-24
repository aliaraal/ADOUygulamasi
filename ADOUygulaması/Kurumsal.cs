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
    public partial class Kurumsal : Form
    {
        public Kurumsal()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kurumsal krmsl = new Kurumsal();
            krmsl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 krmsl = new Form1();
            krmsl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferSaatleri krmsl = new SeferSaatleri();
            krmsl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Biletlerim krmsl = new Biletlerim();
            krmsl.Show();
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
