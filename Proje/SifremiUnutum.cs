using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class SifremiUnutum : Form
    {
        public SifremiUnutum()
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
        private void btnSıfreUnuttum_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            if (txtYetkiliTc.Text== "12345678910")
            {
                istemci.Credentials = new System.Net.NetworkCredential("garentaarackiralama@gmail.com", "123456789Csharp");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mesaj.To.Add(txtUyelikMail.Text);
                mesaj.From = new MailAddress("garentaarackiralama@gmail.com");
                mesaj.Subject = "Giriş Bilgileriniz";
                mesaj.Body = "KULLANICI ADI :  admin / ŞİFRE : 1";
                istemci.Send(mesaj);
                MessageBox.Show("Giriş Bilgileriniz Girmiş Olduğunuz Maile Gönderildi","Garenta Araç Kiralama");
            }
            else
            {
                MessageBox.Show("Lütfen Türkiye Cumhuriyeti Kimlik Numaranızı Kontrol Ediniz", "Garenta Araç Kiralama");
            }
        }

        private void SifremiUnutum_Load(object sender, EventArgs e)
        {

        }

     
    }
}
