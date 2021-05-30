using System;
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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

     

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PLC6DRU\\SQLEXPRESS;Initial Catalog=AracKiralama;Integrated Security=True");
        public void connect()
        {

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
        }
        private void btnYetkili_Click_1(object sender, EventArgs e)
        {
            connect();
            SqlCommand command =new SqlCommand("select * from YetkiliBilgiler where YetkiliKullaniciAdi=@YetkiliKullaniciAdi AND YetkiliSifre=@YetkiliSifre", baglan);
            command.Parameters.AddWithValue("YetkiliKullaniciAdi",txtYetkilikAdi.Text);
            command.Parameters.AddWithValue("YetkiliSifre",txtYetkiliSifre.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Hoş Geldin Patron", "Garenta Araç Kiralama");
                YetkiliGiris fr = new YetkiliGiris();
                fr.Show();
                reader.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Tekrar Deneyiniz","Garenta Araç Kiralama");
                reader.Close();
            }
            
        }

        private void btnYetkili_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            if (txtMusteriTc.Text==""&&txtMusteriSifre.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz", "Garenta Araç Kiralama");
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
               
            }  
            else 
            {
                MessageBox.Show("Bu Özellik Şuanda Kullanılamıyor,Daha Sonra Tekrar Deneyiniz", "Garenta Araç Kiralama");
            }
            
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl fr = new UyeOl();
            fr.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSifreMusteri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sistem Yoğunluğundan Dolayı İşleminizi Gerçekleştiremiyoruz . Daha Sonra Tekrar Deneyiniz","Garenta Araç Kiralama");
        }

        private void lblSifreYetkili_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnutum fr = new SifremiUnutum();
            fr.Show();
        }

        private void btnİstekSikayet_Click(object sender, EventArgs e)
        {
            İstekSikayet fr = new İstekSikayet();
            fr.Show();
        }
    }
}
