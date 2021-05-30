using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class İstekSikayet : Form
    {
        public İstekSikayet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                if (txtMail.Text!=null&&txtMail.Text!="@gmail.com")
                {
                    
                        istemci.Credentials = new System.Net.NetworkCredential("garentaarackiralama@gmail.com", "123456789Csharp");
                        istemci.Port = 587;
                        istemci.Host = "smtp.gmail.com";
                        istemci.EnableSsl = true;
                        mesaj.To.Add(txtMail.Text);
                        mesaj.From = new MailAddress("garentaarackiralama@gmail.com");
                        mesaj.Subject = txtKonu.Text;
                        mesaj.Body =  txtAdSoyad.Text +" Kişisinin Mesajı : "+ txtAciklama.Text;
                        istemci.Send(mesaj);

                }
                else 
                {
                    MessageBox.Show("Lütfen Gerekli Alanları Doldurarak Tekrar Deneyiniz !", "Garenta Araç Kiralama");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Gerekli Alanları Doldurarak Tekrar Deneyiniz !","Garenta Araç Kiralama");
            }
           
        }
    }
}
