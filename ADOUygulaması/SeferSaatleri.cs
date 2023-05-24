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
    public partial class SeferSaatleri : Form
    {
        public SeferSaatleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferSaatleri sefersaatleri = new SeferSaatleri();
            sefersaatleri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            ARAL_MİLES_Giriş milesgiris = new ARAL_MİLES_Giriş();
            milesgiris.Show();
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
