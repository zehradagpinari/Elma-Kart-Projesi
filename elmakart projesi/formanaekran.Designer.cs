namespace elmakart_projesi
{
    partial class formanaekran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelisim = new System.Windows.Forms.Label();
            this.txbtutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnodeme = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelisim);
            this.panel1.Controls.Add(this.txbtutar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnodeme);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbtur);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(75, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 320);
            this.panel1.TabIndex = 0;
            // 
            // labelisim
            // 
            this.labelisim.AutoSize = true;
            this.labelisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelisim.Location = new System.Drawing.Point(166, 61);
            this.labelisim.Name = "labelisim";
            this.labelisim.Size = new System.Drawing.Size(56, 18);
            this.labelisim.TabIndex = 1;
            this.labelisim.Text = "kartno";
            // 
            // txbtutar
            // 
            this.txbtutar.Location = new System.Drawing.Point(245, 199);
            this.txbtutar.Name = "txbtutar";
            this.txbtutar.Size = new System.Drawing.Size(100, 22);
            this.txbtutar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(107, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tutar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(-28, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(587, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------------";
            // 
            // btnodeme
            // 
            this.btnodeme.BackColor = System.Drawing.Color.Lime;
            this.btnodeme.Location = new System.Drawing.Point(195, 265);
            this.btnodeme.Name = "btnodeme";
            this.btnodeme.Size = new System.Drawing.Size(114, 33);
            this.btnodeme.TabIndex = 8;
            this.btnodeme.Text = "Ödeme Yap";
            this.btnodeme.UseVisualStyleBackColor = false;
            this.btnodeme.Click += new System.EventHandler(this.btnodeme_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(107, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ödeme Türü:";
            // 
            // cmbtur
            // 
            this.cmbtur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbtur.ForeColor = System.Drawing.Color.White;
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Items.AddRange(new object[] {
            "Öğrenci Kartı",
            "Tam Kişi Kartı",
            "İki Okul Arası",
            "Diş Hastanesi"});
            this.cmbtur.Location = new System.Drawing.Point(245, 162);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(121, 24);
            this.cmbtur.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(242, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(107, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hesap Bakiyesi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(-28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(119, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELMAKART BAKİYE YÜKLEME";
            // 
            // formanaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::elmakart_projesi.Properties.Resources.WhatsApp_Görsel_2025_12_19_saat_14_53_58_a956558a;
            this.ClientSize = new System.Drawing.Size(662, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formanaekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formanaekran";
            this.Load += new System.EventHandler(this.formanaekran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnodeme;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelisim;
        public System.Windows.Forms.ComboBox cmbtur;
        public System.Windows.Forms.TextBox txbtutar;
    }
}