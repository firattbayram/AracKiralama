using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class YetkiliGiris : Form
    {
        public YetkiliGiris()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Giriş Paneline yönlendirileceksiniz onaylıyormusunuz ?", "Garenta Araç Kiralama", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void YetkiliGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListesi fr = new MusteriListesi();
            fr.Show();
        }

        private void btnİstekSikayet_Click(object sender, EventArgs e)
        {
            İstekSikayet fr = new İstekSikayet();
            fr.Show();
        }

        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            AracKayit fr = new AracKayit();
            fr.ShowDialog();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListesi fr = new AracListesi();
            fr.Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            AracSozlesme fr = new AracSozlesme();
            fr.Show();
        }
    }
}
