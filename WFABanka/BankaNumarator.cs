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
            RastgeleBireyselMusteriOlustur();
            RastgeleVipMusteriOlustur();
            MusterileriYukle();
        }

        private void RastgeleBireyselMusteriOlustur()
        {
            for (int i = 0; i < 10; i++)
            {
                string ad = RastgeleAdUret();
                string soyad = RastgeleSoyadUret();
                string tcNo = RastgeleTcUret();

                db.Musteriler.BireyselMusteriler.Add(new Musteri(tcNo) { Ad = ad, Soyad = soyad });
            }
        }

        private void RastgeleVipMusteriOlustur()
        {
            for (int i = 0; i < 10; i++)
            {
                string ad = RastgeleAdUret();
                string soyad = RastgeleSoyadUret();
                string tcNo = RastgeleTcUret();

                db.Musteriler.VipMusteriler.Add(new Musteri(tcNo) { Ad = ad, Soyad = soyad });
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
            dgvVipMusteriler.DataSource = db.Musteriler.VipMusteriler;
            dgvBireyselMusteriler.DataSource = db.Musteriler.BireyselMusteriler;
        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            txtTcNo.MaxLength = 11;
            btnSiraAl.Enabled = txtTcNo.Text.Length == 11 ? true : false;
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            var musteri = SiradakiMusteriyiBelirle();

            if (db.Gise.SiradakiMusteriler.Any(x => x.TcNo == musteri.TcNo))
            {
                MessageBox.Show("Girilen müşteriye ait sıra girişi mevcut! Tekrar sıra alınamaz.");
                txtTcNo.Clear();
                return;
            }

            musteri.SiraAl(db.Numarator);
            EkranaYaz(musteri);
            txtTcNo.Clear();
        }

        private void EkranaYaz(Musteri musteri)
        {
            lblMusteri.ForeColor = Color.Red;
            lblMusteri.Text = db.Musteriler.VipMusteriler.Any(x => x.TcNo == musteri.TcNo) || db.Musteriler.BireyselMusteriler.Any(x => x.TcNo == musteri.TcNo) ? $"{musteri.Ad} {musteri.Soyad}\r\nSıra No : {musteri.SiraNo}" : $"Sıra No: {musteri.SiraNo}";
        }

        private Musteri SiradakiMusteriyiBelirle()
        {
            string tcNo = txtTcNo.Text;

            //SıraAl metoduna gönderilecek müşterinin tipine karar veriyoruz.
            var musteri = db.Musteriler.VipMusteriler.Any(x => x.TcNo == tcNo) ? db.Musteriler.VipMusteriler.FirstOrDefault(x => x.TcNo == tcNo) : db.Musteriler.BireyselMusteriler.Any(x => x.TcNo == tcNo) ? db.Musteriler.BireyselMusteriler.FirstOrDefault(x => x.TcNo == tcNo) : new Musteri(txtTcNo.Text) { Ad = RastgeleAdUret(), Soyad = RastgeleSoyadUret() };

            return musteri!;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Basılan tuşun rakam olup olmadığını kontrol ediyor.
            {
                e.Handled = true; //Eğer basılan tuş rakam değilse yazmaya izin vermiyor.
            }
        }
    }
}
