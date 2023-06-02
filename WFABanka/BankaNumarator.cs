using Banka.Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABanka
{
    public partial class BankaNumarator : Form
    {
        BankaVeri db = new BankaVeri();
        Random random = new Random();

        public BankaNumarator()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            RastgeleNormalMusteriOlustur();
            RastgeleVipMusteriOlustur();
            MusterileriYukle();
        }

        private void RastgeleNormalMusteriOlustur()
        {
            for (int i = 0; i < 10; i++)
            {
                string ad = RastgeleAdUret();
                string soyad = RastgeleSoyadUret();
                string tcNo = RastgeleTcUret();

                db.BireyselMusteriler.Add(new Musteri(tcNo) { Ad = ad, Soyad = soyad });
            }
        }

        private void RastgeleVipMusteriOlustur()
        {
            for (int i = 0; i < 10; i++)
            {
                string ad = RastgeleAdUret();
                string soyad = RastgeleSoyadUret();
                string tcNo = RastgeleTcUret();

                db.VipMusteriler.Add(new Musteri(tcNo) { Ad = ad, Soyad = soyad });
            }
        }

        private string RastgeleAdUret()
        {
            List<string> adlar = new List<string> { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali", "Ayşegül", "Can", "Deniz", "Ebru", "Fikret", "Gülay", "Hakan", "İrem", "Jale", "Kadir", "Leyla", "Murat", "Nalan", "Okan", "Pınar" };

            return adlar[random.Next(adlar.Count)];
        }

        private string RastgeleSoyadUret()
        {
            List<string> soyadlar = new List<string> { "Yılmaz", "Demir", "Kaya", "Çelik", "Arslan", "Koç", "Yıldız", "Aslan", "Kurt", "Sarı", "Öztürk", "Taş", "Aydın", "Güler", "Ergün", "Özdemir", "Şahin", "Gündüz", "Bulut", "Korkmaz" };

            return soyadlar[random.Next(soyadlar.Count)];
        }

        private string RastgeleTcUret()
        {
            return random.NextInt64(10000000000, 99999999999).ToString();
        }

        private void MusterileriYukle()
        {
            dgvVipMusteriler.AutoGenerateColumns = false;
            dgvBireyselMusteriler.AutoGenerateColumns = false;
            dgvVipMusteriler.DataSource = null;
            dgvBireyselMusteriler.DataSource = null;
            dgvVipMusteriler.DataSource = db.VipMusteriler;
            dgvBireyselMusteriler.DataSource = db.BireyselMusteriler;
        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            txtTcNo.MaxLength = 11;
            btnSiraAl.Enabled = txtTcNo.Text.Length == 11 ? true : false;
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            if (TcMevcutMu())
            {
                var musteri = db.VipMusteriler.Any(x => x.TcNo == txtTcNo.Text) ? db.VipMusteriler.FirstOrDefault(x => x.TcNo == txtTcNo.Text) : db.BireyselMusteriler.FirstOrDefault(x => x.TcNo == txtTcNo.Text);

                musteri!.SiraAl(db.Numarator);
                EkranaYaz(musteri);
            }
            else
            {
                var musteri = new Musteri(txtTcNo.Text) { Ad = RastgeleAdUret(), Soyad = RastgeleSoyadUret() };
                musteri.SiraAl(db.Numarator);
                EkranaYaz(musteri);
            }

            txtTcNo.Clear();
        }

        private void EkranaYaz(Musteri musteri)
        {
            lblMusteri.ForeColor = Color.Red;
            lblMusteri.Text = $"{musteri.Ad} {musteri.Soyad}\r\nSıra No : {musteri.SiraNo}";
        }

        private bool TcMevcutMu()
        {
            string tcNo = txtTcNo.Text;

            return db.VipMusteriler.Any(x => x.TcNo == tcNo) ? true : db.BireyselMusteriler.Any(x => x.TcNo == tcNo);
        }

        private void btnGiseyeGit_Click(object sender, EventArgs e)
        {
            new BankaGise(db).ShowDialog();
        }

        private void btnMusterileriGoster_Click(object sender, EventArgs e)
        {
            if (btnMusterileriGoster.Text == "MÜŞTERİLERİ GÖSTER")
            {
                scMusteriler.Show();
                btnMusterileriGoster.Text = "MÜŞTERİLERİ GİZLE";
            }
            else
            {
                scMusteriler.Hide();
                btnMusterileriGoster.Text = "MÜŞTERİLERİ GÖSTER";
            }
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
