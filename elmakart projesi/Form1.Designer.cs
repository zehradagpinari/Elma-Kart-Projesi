namespace elmakart_projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsifregoster = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsifreunuttum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbkartno = new System.Windows.Forms.TextBox();
            this.txbsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnsifregoster);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnsifreunuttum);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbkartno);
            this.panel1.Controls.Add(this.txbsifre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(68, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 320);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(-38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(595, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------------------------------";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::elmakart_projesi.Properties.Resources.WhatsApp_Görsel_2025_12_15_saat_15_421;
            this.pictureBox2.Location = new System.Drawing.Point(112, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::elmakart_projesi.Properties.Resources.kilitt__1_;
            this.pictureBox1.Location = new System.Drawing.Point(100, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnsifregoster
            // 
            this.btnsifregoster.BackColor = System.Drawing.Color.Transparent;
            this.btnsifregoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsifregoster.FlatAppearance.BorderSize = 0;
            this.btnsifregoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsifregoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsifregoster.Location = new System.Drawing.Point(370, 162);
            this.btnsifregoster.Name = "btnsifregoster";
            this.btnsifregoster.Size = new System.Drawing.Size(26, 22);
            this.btnsifregoster.TabIndex = 10;
            this.btnsifregoster.Text = "\r\n";
            this.btnsifregoster.UseVisualStyleBackColor = false;
            this.btnsifregoster.Click += new System.EventHandler(this.btnsifregoster_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(338, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kayıt Ol";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsifreunuttum
            // 
            this.btnsifreunuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsifreunuttum.Location = new System.Drawing.Point(338, 232);
            this.btnsifreunuttum.Name = "btnsifreunuttum";
            this.btnsifreunuttum.Size = new System.Drawing.Size(125, 31);
            this.btnsifreunuttum.TabIndex = 8;
            this.btnsifreunuttum.Text = "Şifremi Unuttum";
            this.btnsifreunuttum.UseVisualStyleBackColor = false;
            this.btnsifreunuttum.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(112, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(-22, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------";
            // 
            // txbkartno
            // 
            this.txbkartno.ForeColor = System.Drawing.Color.Gray;
            this.txbkartno.Location = new System.Drawing.Point(165, 124);
            this.txbkartno.Name = "txbkartno";
            this.txbkartno.Size = new System.Drawing.Size(231, 22);
            this.txbkartno.TabIndex = 5;
            this.txbkartno.Text = "Kart  Numarası";
            this.txbkartno.Enter += new System.EventHandler(this.txbkartno_Enter);
            this.txbkartno.Leave += new System.EventHandler(this.txbkartno_Leave);
            // 
            // txbsifre
            // 
            this.txbsifre.Location = new System.Drawing.Point(165, 162);
            this.txbsifre.MaxLength = 8;
            this.txbsifre.Name = "txbsifre";
            this.txbsifre.PasswordChar = '*';
            this.txbsifre.Size = new System.Drawing.Size(231, 22);
            this.txbsifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(206, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\nAMASYA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(121, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ELMAKART PARA YÜKLEME UYGULAMASI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::elmakart_projesi.Properties.Resources.WhatsApp_Görsel_2025_12_19_saat_14_53_58_a956558a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbkartno;
        private System.Windows.Forms.TextBox txbsifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnsifreunuttum;
        private System.Windows.Forms.Button btnsifregoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

