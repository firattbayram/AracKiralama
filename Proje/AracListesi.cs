using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AracKiralama
{
    public partial class AracListesi : Form
    {
        public AracListesi()
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
        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void AracListesi_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  AracBilgiler  ORDER BY AracPlaka  ASC", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbAracMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbAracModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtModelYil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbYakit.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtKiraFiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

              connect();
            SqlCommand command = new SqlCommand("update AracBilgiler set AracPlaka=@AracPlaka,AracMarka=@AracMarka,AracModel=@AracModel,AracModelYil=@AracModelYil,AracRenk=@AracRenk ,AracKm=@AracKm,AracYakit=@AracYakit,AracKiraFiyat=@AracKiraFiyat,AracResim=@AracResim     where AracPlaka=@AracPlaka", baglan);
            command.Parameters.AddWithValue("@AracPlaka", txtPlaka.Text);
            command.Parameters.AddWithValue("@AracMarka", cmbAracMarka.Text);
            command.Parameters.AddWithValue("@AracModel", cmbAracModel.Text);
            command.Parameters.AddWithValue("@AracModelYil", txtModelYil.Text);
            command.Parameters.AddWithValue("@AracRenk", txtRenk.Text);
            command.Parameters.AddWithValue("@AracKm", txtKm.Text);
            command.Parameters.AddWithValue("@AracYakit", cmbYakit.Text);
            command.Parameters.AddWithValue("@AracKiraFiyat", txtKiraFiyat.Text);
            command.Parameters.AddWithValue("@AracResim", pictureBox1.ImageLocation);
            command.ExecuteNonQuery();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı", "Araç Listesi / Garenta");

            }
            else
            {
                MessageBox.Show("İşlem Başarısız , Lütfen Tekrar Deneyiniz !!", "Araç Listesi / Garenta");
            }
            listele();
        }

        private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbAracModel.Items.Clear();
                if (cmbAracMarka.SelectedIndex == 0)
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

        private void btnSil_Click(object sender, EventArgs e)
        {
          DialogResult onay=  MessageBox.Show("Silme İşlemi Yapılacaktır , Onaylıyormusnuz ?", "Garenta Araç Kiralaama", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (onay==DialogResult.Yes)
            {
                connect();
                SqlCommand command = new SqlCommand("delete from AracBilgiler where AracPlaka=@AracPlaka", baglan);
                command.Parameters.AddWithValue("@AracPlaka", txtPlaka.Text);
                command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() > -1)
                {
                    MessageBox.Show("Silme İşlemi Başarılı", "Garenta Araç Kiralama");
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Başarısız", "Garenta Araç Kiralama");

                }
            }
            listele();
           
        }
    }
}
