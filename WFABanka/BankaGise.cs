using Banka.Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABanka
{
    public partial class BankaGise : Form
    {
        private readonly BankaVeri _db;
        public BankaGise(BankaVeri db)
        {
            _db = db;
            InitializeComponent();
            SiradakileriGoster();
            BilgisayarEkraniniYukle();
            TamamlananIslemAdediYaz();
            GisedeMusteriVarMi();
        }

        private void GisedeMusteriVarMi()
        {
            if (_db.Gise.IslemYapanMusteri != null)
            {
                lblSiraNo.Text = _db.Gise.IslemYapanMusteri!.SiraNo.ToString("000");
                btnIslemiTamamla.Enabled = _db.Gise.IslemiTamamlananMusteriler.Contains(_db.Gise.IslemYapanMusteri) ? false : true;
            }
        }

        private void SiradakileriGoster()
        {
            dgvSiradakiMusteriler.AutoGenerateColumns = false;
            dgvSiradakiMusteriler.DataSource = null;
            dgvSiradakiMusteriler.DataSource = _db.Gise.SiradakiMusteriler;
        }

        private void btnSiradakiMusteri_Click(object sender, EventArgs e)
        {
            if (_db.Gise.SiradakiMusteriler.Count == 0)
            {
                MessageBox.Show("Sırada bekleyen müşteri yok !");
                return;
            }

            _db.Gise.SiradakiIslem();
            GisedeMusteriVarMi();
        }

        private void BilgisayarEkraniniYukle()
        {
            dgvBekleyenMusteriler.AutoGenerateColumns = false;
            dgvBekleyenMusteriler.DataSource = null;
            dgvBekleyenMusteriler.DataSource = _db.Gise.SiradakiMusteriler;
            dgvIslemiTamamlananMusteriler.AutoGenerateColumns = false;
            dgvIslemiTamamlananMusteriler.DataSource = null;
            dgvIslemiTamamlananMusteriler.DataSource = _db.Gise.IslemiTamamlananMusteriler;
        }

        private void btnIslemiTamamla_Click(object sender, EventArgs e)
        {
            if (_db.Gise.IslemYapanMusteri == null)
            {
                MessageBox.Show("Gişede işlem yapan müşteri yok !");
                return;
            }

            _db.Gise.MusteriIsleminiTamamla();
            TamamlananIslemAdediYaz();
            btnIslemiTamamla.Enabled = false;
        }

        private void TamamlananIslemAdediYaz()
        {
            Temizle();
            lblGise.Text = _db.Gise.TamamlananIslemler.GiseIslemleri.Count.ToString();
            lblBireysel.Text = _db.Gise.TamamlananIslemler.BireyselIslemler.Count.ToString();
            lblVip.Text = _db.Gise.TamamlananIslemler.VipIslemler.Count.ToString();
        }

        private void Temizle()
        {
            lblGise.Text = string.Empty;
            lblBireysel.Text = string.Empty;
            lblVip.Text = string.Empty;
        }
    }
}
