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
    public partial class UyeOl : Form
    {
        public UyeOl()
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
        private void UyeOl_Load(object sender, EventArgs e)
        {
          
        }



        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                SqlCommand command = new SqlCommand("Insert into MusteriUyelik values(@MusteriTc,@MusteriAdSoyad,@MusteriSifre,@MusteriCepTel,@MusteriMail,@MusteriEhliyet)", baglan);
                command.Parameters.AddWithValue("@MusteriTc", txtUyelikTc.Text);
                command.Parameters.AddWithValue("@MusteriAdSoyad", txtUyelikAdSoyad.Text);
                command.Parameters.AddWithValue("@MusteriSifre", txtUyelikSifre.Text);
                command.Parameters.AddWithValue("@MusteriCepTel", txtUyelikTel.Text);
                command.Parameters.AddWithValue("@MusteriMail", txtUyelikMail.Text);
                command.Parameters.AddWithValue("@MusteriEhliyet", cmbUyelikEhliyet.Text);

                command.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Üyelik İşleminiz Tamamlandı Sisteme Giriş Yapabilirsiniz", "Garenta Araç Kiralama");
                this.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Tekrar Deneyiniz !"+hata.Message,"Garenta Araç Kiralama");
            }
          
        }

      
    }
}
