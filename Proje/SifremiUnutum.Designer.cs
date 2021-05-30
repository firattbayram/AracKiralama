
namespace AracKiralama
{
    partial class SifremiUnutum
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtUyelikMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYetkiliTc = new System.Windows.Forms.TextBox();
            this.btnSıfreUnuttum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MAİL ADRESİ";
            // 
            // txtUyelikMail
            // 
            this.txtUyelikMail.Location = new System.Drawing.Point(100, 57);
            this.txtUyelikMail.MaxLength = 35;
            this.txtUyelikMail.Name = "txtUyelikMail";
            this.txtUyelikMail.Size = new System.Drawing.Size(162, 20);
            this.txtUyelikMail.TabIndex = 10;
            this.txtUyelikMail.Text = "@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC KİMLİK";
            // 
            // txtYetkiliTc
            // 
            this.txtYetkiliTc.Location = new System.Drawing.Point(100, 31);
            this.txtYetkiliTc.MaxLength = 11;
            this.txtYetkiliTc.Name = "txtYetkiliTc";
            this.txtYetkiliTc.Size = new System.Drawing.Size(125, 20);
            this.txtYetkiliTc.TabIndex = 12;
            // 
            // btnSıfreUnuttum
            // 
            this.btnSıfreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıfreUnuttum.ForeColor = System.Drawing.Color.Black;
            this.btnSıfreUnuttum.Location = new System.Drawing.Point(100, 83);
            this.btnSıfreUnuttum.Name = "btnSıfreUnuttum";
            this.btnSıfreUnuttum.Size = new System.Drawing.Size(162, 26);
            this.btnSıfreUnuttum.TabIndex = 14;
            this.btnSıfreUnuttum.Text = "Şifremi Gönder";
            this.btnSıfreUnuttum.UseVisualStyleBackColor = true;
            this.btnSıfreUnuttum.Click += new System.EventHandler(this.btnSıfreUnuttum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSıfreUnuttum);
            this.groupBox1.Controls.Add(this.txtUyelikMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYetkiliTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 128);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Hatırla";
            // 
            // SifremiUnutum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(321, 156);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 195);
            this.Name = "SifremiUnutum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi Unutum / Garenta";
            this.Load += new System.EventHandler(this.SifremiUnutum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUyelikMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYetkiliTc;
        private System.Windows.Forms.Button btnSıfreUnuttum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}