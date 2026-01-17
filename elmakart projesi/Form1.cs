using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using elmakart_projesi;

namespace elmakart_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbkartno.Text = "Kart Numarası";
            txbkartno.ForeColor = Color.Gray;

            txbsifre.UseSystemPasswordChar = false;
            txbsifre.PasswordChar = '*'; 

            btnsifregoster.BackgroundImage = Properties.Resources.kapaligöz;
            btnsifregoster.BackgroundImageLayout = ImageLayout.Zoom;

            panel1.BackColor = Color.FromArgb(230, 30, 30, 30);

            txbkartno.MaxLength = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kartNoTemiz = txbkartno.Text.Replace(" ", "");
            string sifre = txbsifre.Text;

            bool harfVar = sifre.Any(char.IsLetter);
            bool sayiVar = sifre.Any(char.IsDigit);

            // GÜVENLİK KONTROLLERİ
            if (string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen şifre alanını doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sifre.Length < 8 || !harfVar || !sayiVar)
            {
                MessageBox.Show("Şifreniz en az 8 karakter olmalı, en az bir harf ve bir rakam içermelidir!", "Zayıf Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(kartNoTemiz) || kartNoTemiz.Length < 8)
            {
                MessageBox.Show("Kart numarası 8 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               


                var kullanici = VeriDeposu.Kullanicilar.Find(k => k.KartNo == kartNoTemiz && k.Sifre == sifre);

                if (kullanici != null)
                {
                    formanaekran ekran = new formanaekran();
                    ekran.kullaniciAdi = kartNoTemiz; 
                    ekran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kart numarası veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (txbkartno.Text == "Kart Numarası" || string.IsNullOrWhiteSpace(txbkartno.Text))
            {
                MessageBox.Show("Lütfen kart numaranızı giriniz!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            şifremiunuttuö sifreFormu = new şifremiunuttuö();
            sifreFormu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formkayitol kayitFormu = new Formkayitol();
            kayitFormu.ShowDialog(); 
        }



        private void btnsifregoster_Click(object sender, EventArgs e)
        {
            txbsifre.UseSystemPasswordChar = false;

            if (txbsifre.PasswordChar == '*')
            {
                txbsifre.PasswordChar = '\0';
                btnsifregoster.BackgroundImage = Properties.Resources.açıkgöz;
            }
            else
            {
                txbsifre.PasswordChar = '*';
                btnsifregoster.BackgroundImage = Properties.Resources.kapaligöz;
            }
        }

        private void txbkartno_Enter(object sender, EventArgs e)
        {
            if (txbkartno.Text == "Kart Numarası")
            {
                txbkartno.Text = "";
                txbkartno.ForeColor = Color.Black; 
            }
        }

        private void txbkartno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbkartno.Text))
            {
                txbkartno.Text = "Kart Numarası"; 
                txbkartno.ForeColor = Color.Gray; 
            }
        }
    }
}