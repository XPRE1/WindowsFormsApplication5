namespace TarimUygulamasi
{
    partial class MainForm
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
            this.sifreHatırlat = new System.Windows.Forms.Label();
            this.kullaniciEkle = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.girisButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifreHatırlat
            // 
            this.sifreHatırlat.AutoSize = true;
            this.sifreHatırlat.Location = new System.Drawing.Point(369, 270);
            this.sifreHatırlat.Name = "sifreHatırlat";
            this.sifreHatırlat.Size = new System.Drawing.Size(79, 13);
            this.sifreHatırlat.TabIndex = 12;
            this.sifreHatırlat.Text = "Şifremi unuttum";
            // 
            // kullaniciEkle
            // 
            this.kullaniciEkle.AutoSize = true;
            this.kullaniciEkle.Location = new System.Drawing.Point(369, 292);
            this.kullaniciEkle.Name = "kullaniciEkle";
            this.kullaniciEkle.Size = new System.Drawing.Size(92, 13);
            this.kullaniciEkle.TabIndex = 11;
            this.kullaniciEkle.Text = "Yeni kullanıcı ekle";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(372, 208);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(146, 20);
            this.sifre.TabIndex = 9;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(372, 177);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(146, 20);
            this.kullaniciAdi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifreniz             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adınız :";
            // 
            // girisButonu
            // 
            this.girisButonu.Location = new System.Drawing.Point(414, 234);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(65, 24);
            this.girisButonu.TabIndex = 6;
            this.girisButonu.Text = "Giriş";
            this.girisButonu.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 483);
            this.Controls.Add(this.sifreHatırlat);
            this.Controls.Add(this.kullaniciEkle);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisButonu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifreHatırlat;
        private System.Windows.Forms.Label kullaniciEkle;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisButonu;
    }
}