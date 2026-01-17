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
    public partial class formodeme : Form
    {
        public formodeme()
        {
            InitializeComponent();
        }
        public string odenecekTutar;
        private void formodeme_Load(object sender, EventArgs e)
        {
            panelodeme.Parent = pictureBox1;
            panelodeme.Location = new Point(50, 35);
            panelodeme.BackColor = Color.FromArgb(240, 30, 30, 30);

            labeltutar.Text = odenecekTutar + " TL";
        }

        private void txbkartno_TextChanged(object sender, EventArgs e)
        {
            string metin = txbkartno.Text.Replace(" ", "");

            string sadeceRakam = "";
            foreach (char c in metin)
            {
                if (char.IsDigit(c)) sadeceRakam += c;
            }


            if (sadeceRakam.Length > 16)
            {
                sadeceRakam = sadeceRakam.Substring(0, 16);
            }

            string formatliMetin = "";
            for (int i = 0; i < sadeceRakam.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                {
                    formatliMetin += " ";
                }
                formatliMetin += sadeceRakam[i];
            }

            if (txbkartno.Text != formatliMetin)
            {
                txbkartno.Text = formatliMetin;
                txbkartno.SelectionStart = txbkartno.Text.Length; 
            }
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            string kartNo = txbkartno.Text.Replace(" ", "");

            if (cmbay.SelectedIndex == -1 || cmbyil.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen son kullanma tarihini (Ay/Yıl) seçiniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txbcvv.Text.Length < 3)
            {
                MessageBox.Show("CVV kodu 3 haneli olmalıdır!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kartNo.Length < 16)
            {
                MessageBox.Show("Kart numarası 16 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Ödeme Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            Formkartdurum kartDurumFormu = new Formkartdurum();

            
            kartDurumFormu.Show();

            
            this.Close();
        }

        private void txbcvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
