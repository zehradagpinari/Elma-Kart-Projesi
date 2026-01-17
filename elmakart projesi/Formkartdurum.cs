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
    public partial class Formkartdurum : Form
    {

        public Formkartdurum()
        {
            InitializeComponent();
        }

        private void Formkartdurum_Load(object sender, EventArgs e)
        {
           
            panel1.Parent = pictureBox1;

            panel1.Location = new Point(50, 35); // Buradaki sayıları kendine göre ayarla
            panel1.BackColor = Color.FromArgb(240, 30, 30, 30);

            lblkartnogoster.Text = ((formanaekran)Application.OpenForms["formanaekran"]).labelisim.Text;

            lblkarttur.Text = ((formanaekran)Application.OpenForms["formanaekran"]).cmbtur.SelectedItem.ToString();

            lblBakiye.Text = ((formanaekran)Application.OpenForms["formanaekran"]).txbtutar.Text;
        }

        private void bTNCIKIS_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
