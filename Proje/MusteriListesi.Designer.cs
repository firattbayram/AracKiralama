
namespace AracKiralama
{
    partial class MusteriListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUyeSifre = new System.Windows.Forms.TextBox();
            this.cmbUyeEhliyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUyeMail = new System.Windows.Forms.TextBox();
            this.txtUyeTel = new System.Windows.Forms.TextBox();
            this.txtUyeAdSoyad = new System.Windows.Forms.TextBox();
            this.txtUyeTc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(507, 92);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(55, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "ŞİFRE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUyeSifre
            // 
            this.txtUyeSifre.Location = new System.Drawing.Point(118, 67);
            this.txtUyeSifre.MaxLength = 15;
            this.txtUyeSifre.Name = "txtUyeSifre";
            this.txtUyeSifre.Size = new System.Drawing.Size(125, 20);
            this.txtUyeSifre.TabIndex = 26;
            // 
            // cmbUyeEhliyet
            // 
            this.cmbUyeEhliyet.FormattingEnabled = true;
            this.cmbUyeEhliyet.Items.AddRange(new object[] {
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
            this.cmbUyeEhliyet.Location = new System.Drawing.Point(384, 65);
            this.cmbUyeEhliyet.Name = "cmbUyeEhliyet";
            this.cmbUyeEhliyet.Size = new System.Drawing.Size(125, 21);
            this.cmbUyeEhliyet.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(270, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "EHLİYET TÜRÜ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(280, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "MAİL ADRESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(275, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "TELEFON  NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "AD SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "TC KİMLİK";
            // 
            // txtUyeMail
            // 
            this.txtUyeMail.Location = new System.Drawing.Point(384, 38);
            this.txtUyeMail.MaxLength = 35;
            this.txtUyeMail.Name = "txtUyeMail";
            this.txtUyeMail.Size = new System.Drawing.Size(162, 20);
            this.txtUyeMail.TabIndex = 19;
            // 
            // txtUyeTel
            // 
            this.txtUyeTel.Location = new System.Drawing.Point(384, 12);
            this.txtUyeTel.MaxLength = 11;
            this.txtUyeTel.Name = "txtUyeTel";
            this.txtUyeTel.Size = new System.Drawing.Size(125, 20);
            this.txtUyeTel.TabIndex = 18;
            // 
            // txtUyeAdSoyad
            // 
            this.txtUyeAdSoyad.Location = new System.Drawing.Point(118, 38);
            this.txtUyeAdSoyad.MaxLength = 70;
            this.txtUyeAdSoyad.Name = "txtUyeAdSoyad";
            this.txtUyeAdSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtUyeAdSoyad.TabIndex = 17;
            // 
            // txtUyeTc
            // 
            this.txtUyeTc.Location = new System.Drawing.Point(118, 12);
            this.txtUyeTc.MaxLength = 11;
            this.txtUyeTc.Name = "txtUyeTc";
            this.txtUyeTc.Size = new System.Drawing.Size(125, 20);
            this.txtUyeTc.TabIndex = 16;
            // 
            // MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(611, 375);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUyeSifre);
            this.Controls.Add(this.cmbUyeEhliyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUyeMail);
            this.Controls.Add(this.txtUyeTel);
            this.Controls.Add(this.txtUyeAdSoyad);
            this.Controls.Add(this.txtUyeTc);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(627, 414);
            this.MinimumSize = new System.Drawing.Size(627, 414);
            this.Name = "MusteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi  / Garenta";
            this.Load += new System.EventHandler(this.MusteriListesi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUyeSifre;
        private System.Windows.Forms.ComboBox cmbUyeEhliyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUyeMail;
        private System.Windows.Forms.TextBox txtUyeTel;
        private System.Windows.Forms.TextBox txtUyeAdSoyad;
        private System.Windows.Forms.TextBox txtUyeTc;
    }
}