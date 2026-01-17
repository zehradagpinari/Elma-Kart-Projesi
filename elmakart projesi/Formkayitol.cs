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
    public partial class Formkayitol : Form
    {
        public Formkayitol()
        {
            InitializeComponent();
        }

        private void Formkayitol_Load(object sender, EventArgs e)
        {
            panelkayit.Parent = pictureBox1;
            panelkayit.Location = new Point(50, 35);
            panelkayit.BackColor = Color.FromArgb(220, 30, 30, 30);

            txbsifre.UseSystemPasswordChar = true;
            txbsifretekrar.UseSystemPasswordChar = true;
            txbkartno.MaxLength = 8;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            string kartNo = txbkartno.Text.Replace(" ", "");
            string sifre = txbsifre.Text;
            string sifreTekrar = txbsifretekrar.Text;

            if (string.IsNullOrWhiteSpace(kartNo) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler birbiriyle eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool harfVar = sifre.Any(char.IsLetter);
            bool sayiVar = sifre.Any(char.IsDigit);

            if (sifre.Length < 8 || !harfVar || !sayiVar)
            {
                MessageBox.Show("Şifreniz en az 8 karakter olmalı, harf ve rakam içermelidir!", "Zayıf Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (VeriDeposu.Kullanicilar.Any(k => k.KartNo == kartNo))
            {
                MessageBox.Show("Bu kart numarası zaten sistemde kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.KartNo = kartNo;
            yeniKullanici.Sifre = sifre;

            VeriDeposu.Kullanicilar.Add(yeniKullanici);

            MessageBox.Show("Kaydınız başarıyla oluşturuldu! Giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
