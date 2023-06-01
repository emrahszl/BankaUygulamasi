using Banka.Data.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class Numarator
    {
        private static int _vipSiraNo = 1000;
        private static int _bireyselSiraNo = 2000;
        private static int _giseSiraNo = 3000;

        public void SiraVer(Musteri musteri, SiradaBekleyenMusteriler siradakiMusteriler)
        {
            if (musteri.TcNo.StartsWith('1'))
            {
                musteri.YapilacakIslem.IslemTipi = Enums.IslemTipi.Vip;
                siradakiMusteriler.Add(musteri);
                musteri.SiraNo = _vipSiraNo++;
            }
            else if (musteri.TcNo.StartsWith('2'))
            {
                musteri.YapilacakIslem.IslemTipi = Enums.IslemTipi.Bireysel;
                siradakiMusteriler.Add(musteri);
                musteri.SiraNo = _bireyselSiraNo++;
            }
            else
            {
                musteri.YapilacakIslem.IslemTipi = Enums.IslemTipi.Gise;
                siradakiMusteriler.Add(musteri);
                musteri.SiraNo = _giseSiraNo++;
            }
        }
    }
}
