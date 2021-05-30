
namespace AracKiralama
{
    partial class AnaSayfa
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
            this.btnMusteri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSifreMusteri = new System.Windows.Forms.LinkLabel();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.txtMusteriTc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSifreYetkili = new System.Windows.Forms.LinkLabel();
            this.txtYetkiliSifre = new System.Windows.Forms.TextBox();
            this.txtYetkilikAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYetkili = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.btnİstekSikayet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.Teal;
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(25, 94);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(162, 27);
            this.btnMusteri.TabIndex = 2;
            this.btnMusteri.Text = "MÜŞTERİ GİRİŞİ İÇİN TIKLAYINIZ";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSifreMusteri);
            this.panel1.Controls.Add(this.txtMusteriSifre);
            this.panel1.Controls.Add(this.txtMusteriTc);
            this.panel1.Controls.Add(this.btnMusteri);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 125);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "BAKIMDA !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tc Kimlik ";
            // 
            // lblSifreMusteri
            // 
            this.lblSifreMusteri.AutoSize = true;
            this.lblSifreMusteri.Location = new System.Drawing.Point(106, 73);
            this.lblSifreMusteri.Name = "lblSifreMusteri";
            this.lblSifreMusteri.Size = new System.Drawing.Size(78, 13);
            this.lblSifreMusteri.TabIndex = 5;
            this.lblSifreMusteri.TabStop = true;
            this.lblSifreMusteri.Text = "ŞifremiUnuttum";
            this.lblSifreMusteri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSifreMusteri_LinkClicked);
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(69, 48);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.PasswordChar = '*';
            this.txtMusteriSifre.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSifre.TabIndex = 4;
            // 
            // txtMusteriTc
            // 
            this.txtMusteriTc.Location = new System.Drawing.Point(69, 22);
            this.txtMusteriTc.MaxLength = 11;
            this.txtMusteriTc.Name = "txtMusteriTc";
            this.txtMusteriTc.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTc.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSifreYetkili);
            this.panel2.Controls.Add(this.txtYetkiliSifre);
            this.panel2.Controls.Add(this.txtYetkilikAdi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnYetkili);
            this.panel2.Location = new System.Drawing.Point(238, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 123);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblSifreYetkili
            // 
            this.lblSifreYetkili.AutoSize = true;
            this.lblSifreYetkili.Location = new System.Drawing.Point(106, 75);
            this.lblSifreYetkili.Name = "lblSifreYetkili";
            this.lblSifreYetkili.Size = new System.Drawing.Size(78, 13);
            this.lblSifreYetkili.TabIndex = 12;
            this.lblSifreYetkili.TabStop = true;
            this.lblSifreYetkili.Text = "ŞifremiUnuttum";
            this.lblSifreYetkili.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSifreYetkili_LinkClicked);
            // 
            // txtYetkiliSifre
            // 
            this.txtYetkiliSifre.Location = new System.Drawing.Point(78, 50);
            this.txtYetkiliSifre.Name = "txtYetkiliSifre";
            this.txtYetkiliSifre.PasswordChar = '*';
            this.txtYetkiliSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiliSifre.TabIndex = 11;
            // 
            // txtYetkilikAdi
            // 
            this.txtYetkilikAdi.Location = new System.Drawing.Point(78, 22);
            this.txtYetkilikAdi.MaxLength = 11;
            this.txtYetkilikAdi.Name = "txtYetkilikAdi";
            this.txtYetkilikAdi.Size = new System.Drawing.Size(100, 20);
            this.txtYetkilikAdi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(31, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // btnYetkili
            // 
            this.btnYetkili.BackColor = System.Drawing.Color.Teal;
            this.btnYetkili.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkili.ForeColor = System.Drawing.Color.Black;
            this.btnYetkili.Location = new System.Drawing.Point(18, 92);
            this.btnYetkili.Name = "btnYetkili";
            this.btnYetkili.Size = new System.Drawing.Size(166, 27);
            this.btnYetkili.TabIndex = 1;
            this.btnYetkili.Text = "YETKİLİ GİRİŞİ İÇİN TIKLAYINIZ";
            this.btnYetkili.UseVisualStyleBackColor = false;
            this.btnYetkili.Click += new System.EventHandler(this.btnYetkili_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(12, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 97);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources.teslim;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.Teal;
            this.btnUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.ForeColor = System.Drawing.Color.Black;
            this.btnUyeOl.Location = new System.Drawing.Point(12, 141);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(199, 27);
            this.btnUyeOl.TabIndex = 13;
            this.btnUyeOl.Text = "ÜYE OL";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // btnİstekSikayet
            // 
            this.btnİstekSikayet.BackColor = System.Drawing.Color.Teal;
            this.btnİstekSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİstekSikayet.ForeColor = System.Drawing.Color.Black;
            this.btnİstekSikayet.Location = new System.Drawing.Point(235, 142);
            this.btnİstekSikayet.Name = "btnİstekSikayet";
            this.btnİstekSikayet.Size = new System.Drawing.Size(206, 27);
            this.btnİstekSikayet.TabIndex = 14;
            this.btnİstekSikayet.Text = "İSTEK / ŞİKAYET";
            this.btnİstekSikayet.UseVisualStyleBackColor = false;
            this.btnİstekSikayet.Click += new System.EventHandler(this.btnİstekSikayet_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(449, 274);
            this.Controls.Add(this.btnİstekSikayet);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 313);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 313);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa / Garenta";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYetkili;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblSifreMusteri;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.TextBox txtMusteriTc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblSifreYetkili;
        private System.Windows.Forms.TextBox txtYetkiliSifre;
        private System.Windows.Forms.TextBox txtYetkilikAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnİstekSikayet;
    }
}

