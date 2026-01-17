using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elmakart_projesi
{
    public partial class formanaekran : Form
    {
        public string kullaniciAdi;

        public formanaekran()
        {
            InitializeComponent();
        }

        private void formanaekran_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 240, 240, 240);
            panel1.BackColor = Color.FromArgb(230, 30, 30, 30);

            labelisim.Text = "Kart No:   " + kullaniciAdi;
        }

        private void btnodeme_Click(object sender, EventArgs e)
        {
            formodeme odemeFormu = new formodeme();
            odemeFormu.odenecekTutar = txbtutar.Text;
            odemeFormu.Show();
            this.Hide();
        }
    }
}
