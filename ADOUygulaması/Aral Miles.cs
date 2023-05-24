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
    public partial class Aral_Miles : Form
    {
        public Aral_Miles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEK KULLANIMLIK KAMPANYA KODU: " +
                "  ARALAS");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEK KULLANIMLIK KAMPANYA KODU: " +
    "  ARALYI");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Bu Hesap 27.04.2023 -- 22:21 Tarihinde Oluşturuldu!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("100 ARAL MILES PUANINIZ VAR!");
        }
    }
}
