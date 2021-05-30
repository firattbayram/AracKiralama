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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
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
        public void listele()
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  MusteriUyelik  ORDER BY MusteriAdSoyad  ASC", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
          
        }

        private void MusteriListesi_Load_1(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUyeTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUyeAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUyeSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUyeTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUyeMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbUyeEhliyet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand command = new SqlCommand("update MusteriUyelik set MusteriAdSoyad=@AdSoyad,MusterıSifre=@Sifre,MusteriCepTel=@Telefon,MusteriMail=@Mail,MusteriEhliyet=@Ehliyet where MusteriTc=@Tc", baglan);
            command.Parameters.AddWithValue("@Tc",txtUyeTc.Text);
            command.Parameters.AddWithValue("@AdSoyad", txtUyeAdSoyad.Text);
            command.Parameters.AddWithValue("@Sifre", txtUyeSifre.Text);
            command.Parameters.AddWithValue("@Telefon", txtUyeTel.Text);
            command.Parameters.AddWithValue("@Mail", txtUyeMail.Text);
            command.Parameters.AddWithValue("@Ehliyet", cmbUyeEhliyet.Text);
            command.ExecuteNonQuery();
            if (command.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı","Müşteri Listesi / Garenta");
              
            }
            else
            {
                MessageBox.Show("İşlem Başarısız , Lütfen Tekrar Deneyiniz !!", "Müşteri Listesi / Garenta");
            }
            listele();

        }
    }
}
