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
    public partial class şifremiunuttuö : Form
    {
        public şifremiunuttuö()
        {
            InitializeComponent();
        }

        private void şifremiunuttuö_Load(object sender, EventArgs e)
        {
            panelşifreunuttum.Parent = pictureBox1;
            panelşifreunuttum.Location = new Point(50, 35);
            panelşifreunuttum.BackColor = Color.FromArgb(200, 30, 30, 30); 

            txbYeniSifre.UseSystemPasswordChar = true;
            txbYeniSİfreTekrar.UseSystemPasswordChar = true;
        }

        private void btnsfreunuttumbitti_Click(object sender, EventArgs e)
        {
            string kartNo = txbKartNo.Text.Replace(" ", ""); 
            string yeniSifre = txbYeniSifre.Text;
            string yeniSifreTekrar = txbYeniSİfreTekrar.Text;

            if (string.IsNullOrWhiteSpace(kartNo) || string.IsNullOrWhiteSpace(yeniSifre) || string.IsNullOrWhiteSpace(yeniSifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları (Kart No dahil) doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Girdiğiniz şifreler birbiriyle eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool harfVar = yeniSifre.Any(char.IsLetter);
            bool sayiVar = yeniSifre.Any(char.IsDigit);

            if (yeniSifre.Length < 8 || !harfVar || !sayiVar)
            {
                MessageBox.Show("Yeni şifreniz en az 8 karakter olmalı, en az bir harf ve bir rakam içermelidir!", "Zayıf Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kisi = VeriDeposu.Kullanicilar.Find(k => k.KartNo == kartNo);

            if (kisi != null)
            {
               
                kisi.Sifre = yeniSifre;

                MessageBox.Show("Şifreniz başarıyla güncellendi! Yeni şifrenizle giriş yapabilirsiniz.",
                                "İşlem Başarılı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                
                Form1 girisFormu = new Form1();
                girisFormu.Show();
                this.Close();
            }
            else
            {
               
                MessageBox.Show("Sistemde bu kart numarasına ait bir kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}