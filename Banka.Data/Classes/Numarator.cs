﻿using Banka.Data.Collections;
using Banka.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class Numarator
    {
        private readonly BankaVeri _db;
        public Numarator(BankaVeri db)
        {
            _db = db;
        }

        private static int _vipSiraNo = 1000; //Vip müşteriler için sıra numaraları 1000'den başlıyor.
        private static int _bireyselSiraNo = 500; //Bireysel müşteriler için sıra numaraları 500'den başlıyor.
        private static int _normalSiraNo = 1; //Normal müşteriler içinse 1'den başlıyor. 

        public void SiraVer(Musteri musteri)
        {
            musteri.OncelikliMi = _db.Musteriler.VipMusteriler.Any(x => x.TcNo == musteri.TcNo) ? true : false; //Banka gelen müşterinin tipine girilen tc no'ya göre karar vermektedir. Eğer numaratörden girilen tc bankanın veritabanındaki müşteriler içerisinde varsa vip müşteri olduğuna karar veriliyor. Buna göre müşterinin öncelikli mi değil mi olduğu atanıyor.

            if (musteri.OncelikliMi) //Müşteri öncelikliyse yapacağı işlemin tipi vip olarak atnıyor ve gişenin sıradaki müşterilerine eklenerek uygun sıra numarası veriliyor.
            {
                musteri.YapilacakIslem.IslemTipi = IslemTipi.Vip;
                musteri.YapilacakIslem.Durum = IslemDurumu.Aktif;
                _db.Gise.SiradakiMusteriler.VipMusteriler.Add(musteri);
                musteri.SiraNo = _vipSiraNo++;
            }
            else //Müşteri öncelikli değilse aynı şekilde yapacağı işlem tipine göre atama yapılıp gişenin sıradaki müşterilerine ekleniyor ve uygun sıra numarası veriliyor.
            {
                if (_db.Musteriler.BireyselMusteriler.Any(x => x.TcNo == musteri.TcNo))
                {
                    musteri.YapilacakIslem.IslemTipi = IslemTipi.Bireysel;
                    musteri.YapilacakIslem.Durum = IslemDurumu.Aktif;
                    _db.Gise.SiradakiMusteriler.BireyselMusteriler.Add(musteri);
                    musteri.SiraNo = _bireyselSiraNo++;
                }
                else
                {
                    musteri.YapilacakIslem.IslemTipi = IslemTipi.Gise;
                    musteri.YapilacakIslem.Durum = IslemDurumu.Aktif;
                    _db.Gise.SiradakiMusteriler.NormalMusteriler.Add(musteri);
                    musteri.SiraNo = _normalSiraNo++;
                }
            }

            SiradakiMusterileriSirala();
        }

        public void SiradakiMusterileriSirala()
        {
            _db.Gise.SiradakiMusteriler.Clear();

            foreach (Musteri vipMusteri in _db.Gise.SiradakiMusteriler.VipMusteriler) //Öncelikliler önce ekleniyor.
            {
                _db.Gise.SiradakiMusteriler.Add(vipMusteri);
            }

            foreach (Musteri bireyselMusteri in _db.Gise.SiradakiMusteriler.BireyselMusteriler) //Daha sonra bireysel müşteriler ekleniyor.
            {
                _db.Gise.SiradakiMusteriler.Add(bireyselMusteri);
            }

            foreach (Musteri normalMusteri in _db.Gise.SiradakiMusteriler.NormalMusteriler) //En son bankanın direkt müşterisi olmayanlar müşteriler ekleniyor.
            {
                _db.Gise.SiradakiMusteriler.Add(normalMusteri);
            }
        }
    }
}
