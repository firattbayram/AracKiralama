
namespace AracKiralama
{
    partial class UyeOl
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
            this.txtUyelikTc = new System.Windows.Forms.TextBox();
            this.txtUyelikAdSoyad = new System.Windows.Forms.TextBox();
            this.txtUyelikTel = new System.Windows.Forms.TextBox();
            this.txtUyelikMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUyelikEhliyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUyelikSifre = new System.Windows.Forms.TextBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUyelikTc
            // 
            this.txtUyelikTc.Location = new System.Drawing.Point(113, 13);
            this.txtUyelikTc.MaxLength = 11;
            this.txtUyelikTc.Name = "txtUyelikTc";
            this.txtUyelikTc.Size = new System.Drawing.Size(125, 20);
            this.txtUyelikTc.TabIndex = 0;
            // 
            // txtUyelikAdSoyad
            // 
            this.txtUyelikAdSoyad.Location = new System.Drawing.Point(113, 39);
            this.txtUyelikAdSoyad.MaxLength = 70;
            this.txtUyelikAdSoyad.Name = "txtUyelikAdSoyad";
            this.txtUyelikAdSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtUyelikAdSoyad.TabIndex = 1;
            // 
            // txtUyelikTel
            // 
            this.txtUyelikTel.Location = new System.Drawing.Point(113, 94);
            this.txtUyelikTel.MaxLength = 11;
            this.txtUyelikTel.Name = "txtUyelikTel";
            this.txtUyelikTel.Size = new System.Drawing.Size(125, 20);
            this.txtUyelikTel.TabIndex = 2;
            this.txtUyelikTel.Text = "0";
            // 
            // txtUyelikMail
            // 
            this.txtUyelikMail.Location = new System.Drawing.Point(113, 120);
            this.txtUyelikMail.MaxLength = 35;
            this.txtUyelikMail.Name = "txtUyelikMail";
            this.txtUyelikMail.Size = new System.Drawing.Size(162, 20);
            this.txtUyelikMail.TabIndex = 3;
            this.txtUyelikMail.Text = "@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TC KİMLİK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AD SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TELEFON  NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "MAİL ADRESİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(-1, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "EHLİYET TÜRÜ";
            // 
            // cmbUyelikEhliyet
            // 
            this.cmbUyelikEhliyet.FormattingEnabled = true;
            this.cmbUyelikEhliyet.Items.AddRange(new object[] {
            "M",
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "G"});
            this.cmbUyelikEhliyet.Location = new System.Drawing.Point(113, 147);
            this.cmbUyelikEhliyet.Name = "cmbUyelikEhliyet";
            this.cmbUyelikEhliyet.Size = new System.Drawing.Size(125, 21);
            this.cmbUyelikEhliyet.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(50, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ŞİFRE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUyelikSifre
            // 
            this.txtUyelikSifre.Location = new System.Drawing.Point(113, 68);
            this.txtUyelikSifre.MaxLength = 15;
            this.txtUyelikSifre.Name = "txtUyelikSifre";
            this.txtUyelikSifre.Size = new System.Drawing.Size(125, 20);
            this.txtUyelikSifre.TabIndex = 14;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Image = global::AracKiralama.Properties.Resources.üyelikk;
            this.btnUyeOl.Location = new System.Drawing.Point(113, 174);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(201, 30);
            this.btnUyeOl.TabIndex = 16;
            this.btnUyeOl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(332, 210);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUyelikSifre);
            this.Controls.Add(this.cmbUyelikEhliyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUyelikMail);
            this.Controls.Add(this.txtUyelikTel);
            this.Controls.Add(this.txtUyelikAdSoyad);
            this.Controls.Add(this.txtUyelikTc);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 249);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 249);
            this.Name = "UyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyelik İşlemleri / Garenta";
            this.Load += new System.EventHandler(this.UyeOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUyelikTc;
        private System.Windows.Forms.TextBox txtUyelikAdSoyad;
        private System.Windows.Forms.TextBox txtUyelikTel;
        private System.Windows.Forms.TextBox txtUyelikMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUyelikEhliyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUyelikSifre;
        private System.Windows.Forms.Button btnUyeOl;
    }
}