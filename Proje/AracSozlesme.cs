﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class AracSozlesme : Form
    {
        public AracSozlesme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PLC6DRU\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");

        public void connect()
        {

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
        }
        public void sozlesmeListele()
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  AracSozlesme ORDER BY MusteriTc", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
          
        }
        private void AracSozlesme_Load(object sender, EventArgs e)
        {
          
            sozlesmeListele();
            listele();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void listele()
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  MusteriUyelik  ORDER BY MusteriAdSoyad  ASC", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAra_Click(object sender, EventArgs e)
        { 
            connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  MusteriUyelik  where MusteriTc ='"+txtAra.Text+"'", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUyeTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUyeAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();     
            txtUyeTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUyeMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbUyeEhliyet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUyeTc.Text = "";
            txtUyeAdSoyad.Text = "";
            txtUyeTel.Text = "";
            txtUyeMail.Text = "@gmail.com";
            cmbUyeEhliyet.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbKiraSuresi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //İLK ARABA 
            if (cmbKiraSuresi.SelectedIndex == 0 && cmbPlaka.SelectedIndex== 0)
            {
                txtAracFiyat.Text = "190";
            }
            else if (cmbKiraSuresi.SelectedIndex == 1 && cmbPlaka.SelectedIndex == 0)
            {
                txtAracFiyat.Text = "380";

            }
            else if (cmbKiraSuresi.SelectedIndex == 2 && cmbPlaka.SelectedIndex == 0)
            {
                txtAracFiyat.Text = "570";
            }
            //İKİNCİ ARABA
           else  if (cmbKiraSuresi.SelectedIndex == 0 && cmbPlaka.SelectedIndex == 1)
            {
                txtAracFiyat.Text = "185";
            }
            else if (cmbKiraSuresi.SelectedIndex == 1 && cmbPlaka.SelectedIndex == 1)
            {
                txtAracFiyat.Text = "370";

            }
            else if (cmbKiraSuresi.SelectedIndex == 2 && cmbPlaka.SelectedIndex == 1)
            {
                txtAracFiyat.Text = "555";
            }
            //ÜÇÜNCÜ ARABA
            else if (cmbKiraSuresi.SelectedIndex == 0 && cmbPlaka.SelectedIndex == 2)
            {
                txtAracFiyat.Text = "145";
            }
            else if (cmbKiraSuresi.SelectedIndex == 1 && cmbPlaka.SelectedIndex == 2)
            {
                txtAracFiyat.Text = "290";

            }
            else if (cmbKiraSuresi.SelectedIndex == 2 && cmbPlaka.SelectedIndex == 2)
            {
                txtAracFiyat.Text = "435";
            }
            //DÖRDÜNCÜ ARABA
            else if (cmbKiraSuresi.SelectedIndex == 0 && cmbPlaka.SelectedIndex == 3)
            {
                txtAracFiyat.Text = "200";
            }
            else if (cmbKiraSuresi.SelectedIndex == 1 && cmbPlaka.SelectedIndex == 3)
            {
                txtAracFiyat.Text = "400";

            }
            else if (cmbKiraSuresi.SelectedIndex == 2 && cmbPlaka.SelectedIndex == 3)
            {
                txtAracFiyat.Text = "600";
            }
            //BEŞİNCİ ARABA
            else if (cmbKiraSuresi.SelectedIndex == 0 && cmbPlaka.SelectedIndex == 4)
            {
                txtAracFiyat.Text = "150";
            }
            else if (cmbKiraSuresi.SelectedIndex == 1 && cmbPlaka.SelectedIndex == 4)
            {
                txtAracFiyat.Text = "300";

            }
            else if (cmbKiraSuresi.SelectedIndex == 2 && cmbPlaka.SelectedIndex == 4)
            {
                txtAracFiyat.Text = "450";
            }

        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKiraSuresi.Text = null;
            txtAracFiyat.Text = null; 
            if ( cmbPlaka.SelectedIndex == 0)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Toshiba\\Desktop\\Araç Listesi\\megane.png";
            }
            else if ( cmbPlaka.SelectedIndex == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Toshiba\\Desktop\\Araç Listesi\\astra.png";

            }
            else if (cmbPlaka.SelectedIndex == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Toshiba\\Desktop\\Araç Listesi\\clio.png";

            }
            else if (cmbPlaka.SelectedIndex == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Toshiba\\Desktop\\Araç Listesi\\egea.png";

            }
            else if (cmbPlaka.SelectedIndex == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Toshiba\\Desktop\\Araç Listesi\\clioturuncu.png";

            }


        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                SqlCommand command3 = new SqlCommand("select * from AracBilgiler where AracPlaka=@PLAKA AND AracDurumu='BOŞ' ", baglan);
                command3.Parameters.AddWithValue("PLAKA", cmbPlaka.Text);
                SqlDataReader reader = command3.ExecuteReader();
                while (reader.Read())
                {

                    connect();
                    SqlCommand command = new SqlCommand("Insert into AracSozlesme(AracPlaka,MusteriTc,AracKiraSuresi,AracKiraFiyat,AracVerisTarihi,TeslimDurumu) values(@PLAKA,@MUSTERİTC,@KİRASURESİ,@KİRAFİYAT,@ARACVERİS,@TESLIMDURUMU )", baglan);
                    command.Parameters.AddWithValue("@PLAKA", cmbPlaka.Text);
                    command.Parameters.AddWithValue("@MUSTERİTC", txtUyeTc.Text);
                    command.Parameters.AddWithValue("@KİRASURESİ", cmbKiraSuresi.Text);
                    command.Parameters.AddWithValue("@KİRAFİYAT", txtAracFiyat.Text);
                    command.Parameters.AddWithValue("@ARACVERİS", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@TESLIMDURUMU", "TESLİM EDİLDİ");
                    command.ExecuteNonQuery();
                    sozlesmeListele();
                    SqlCommand command2 = new SqlCommand("update AracBilgiler set AracDurumu=@ARACDURUMU where AracPlaka=@ARACPLAKA", baglan);
                    command2.Parameters.AddWithValue("@ARACDURUMU", "KULLANILIYOR");
                    command2.Parameters.AddWithValue("@ARACPLAKA", cmbPlaka.Text);
                    command2.ExecuteNonQuery();

                }
                reader.Close();
            }
            catch (Exception hatamesaji)
            {

                MessageBox.Show("HATA !"+hatamesaji.Message,"Garenta Araç Kiralama");
            } 
          
        }       
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUyeTc.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
