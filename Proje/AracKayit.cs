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
    public partial class AracKayit : Form
    {
        public AracKayit()
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
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void cmbAracAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbAracModel.Items.Clear();
                if (cmbAracMarka.SelectedIndex==0)
                {
                    cmbAracModel.Items.Add("Linea");
                    cmbAracModel.Items.Add("Doblo");
                    cmbAracModel.Items.Add("Egea");
                    cmbAracModel.Items.Add("Fiorino");
                }
                else if (cmbAracMarka.SelectedIndex == 1)
                {                  
                    cmbAracModel.Items.Add("Astra");
                    cmbAracModel.Items.Add("Corsa");
                    cmbAracModel.Items.Add("Insignia");
                    
                }
                else if (cmbAracMarka.SelectedIndex == 2)
                {                 
                    cmbAracModel.Items.Add("Focus");
                    cmbAracModel.Items.Add("Fiesta");
                    cmbAracModel.Items.Add("Connect");
                    cmbAracModel.Items.Add("Tourneo");
                }
                else if (cmbAracMarka.SelectedIndex == 3)
                {                
                    cmbAracModel.Items.Add("Clio");
                    cmbAracModel.Items.Add("Megane");
                    cmbAracModel.Items.Add("Symbol");
                    cmbAracModel.Items.Add("Captur");
                }
               
            }
            catch 
            {
                //FİAT    FORD      RENAULT     OPEL   
                ;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                SqlCommand command = new SqlCommand("insert into AracBilgiler(AracPlaka,AracMarka,AracModel,AracModelYil" +
                    ",AracRenk,AracKm,AracYakit,AracKiraFiyat,AracResim,AracTarih,AracDurumu) values (@AracPlaka,@AracMarka,@AracModel" +
                    ",@AracModelYil" +
                    ",@AracRenk,@AracKm,@AracYakit,@AracKiraFiyat,@AracResim,@AracTarih,@AracDurumu)", baglan);
                command.Parameters.AddWithValue("@AracPlaka", txtPlaka.Text);
                command.Parameters.AddWithValue("@AracMarka", cmbAracMarka.Text);
                command.Parameters.AddWithValue("@AracModel", cmbAracModel.Text);
                command.Parameters.AddWithValue("@AracModelYil", txtModelYil.Text);
                command.Parameters.AddWithValue("@AracRenk", txtRenk.Text);
                command.Parameters.AddWithValue("@AracKm", txtKm.Text);
                command.Parameters.AddWithValue("@AracYakit", cmbYakit.Text);
                command.Parameters.AddWithValue("@AracKiraFiyat", txtKiraFiyat.Text);
                if (pictureBox1.Image!=null)
                {
                    command.Parameters.AddWithValue("@AracResim", pictureBox1.ImageLocation);
                    command.Parameters.AddWithValue("@AracTarih", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@AracDurumu", "BOŞ");
                    command.ExecuteNonQuery();
                    MessageBox.Show("Araç Başarı İle Eklendi", "Garenta Araç Kiralama");
                  
                    
                }
                else if (pictureBox1.Image==null)
                {
                    MessageBox.Show("Lütfen Resim Ekleyiniz ve Gerekli Alanları Doldurunuz","Garenta Araç Kiralama");
                }
                

            }
            catch
            {
                MessageBox.Show("Araç Eklenemedi", "Garenta Araç Kiralama");
            }

            txtPlaka.Text = null;
            txtModelYil.Text = null;
            txtKm.Text = null;
            txtKiraFiyat.Text = null;
            txtRenk.Text = null;
            cmbAracMarka.Text = null;
            cmbAracModel.Text = null;
            cmbYakit.Text = null;
            pictureBox1.Image = null;



        }

        private void AracKayit_Load(object sender, EventArgs e)
        {

        }

        private void cmbAracModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
