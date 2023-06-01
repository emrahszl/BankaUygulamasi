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
        BankaVeri db = new BankaVeri();

        private static int _vipSiraNo = 1000; //Vip müşteriler için sıra numaraları 1000'den başlıyor.
        private static int _normalSiraNo = 2000; //Normal müşteriler içinse 2000'den başlıyor. 

        public void SiraVer(Musteri musteri)
        {
            musteri.OncelikliMi = musteri.TcNo.StartsWith('1') ? true : false; //Bankanın vip müşterilerini anlaması için tc numarası '1' ile başlayan tüm müşteriler vip müşteri olarak kabul ediliyor. Buna göre müşterinin öncelikli mi değil mi olduğu atanıyor.

            if (musteri.OncelikliMi) //Müşteri öncelikliyse yapacağı işlemin tipi vip olarak atnıyor ve gişenin sıradaki müşterilerine eklenerek uygun sıra numarası veriliyor.
            {
                musteri.YapilacakIslem.IslemTipi = Enums.IslemTipi.Vip;
                db.Gise.SiradakiMusteriler.Add(musteri);
                musteri.SiraNo = _vipSiraNo++;
            }
            else //Müşteri öncelikli değilse aynı şekilde yapacağı işlem tipine göre atama yapılıp gişenin sıradaki müşterilerine ekleniyor ve uygun sıra numarası veriliyor.
            {
                if (musteri.TcNo.StartsWith('2'))
                {
                    musteri.YapilacakIslem.IslemTipi = Enums.IslemTipi.Bireysel;
                    db.Gise.SiradakiMusteriler.Add(musteri);
                    musteri.SiraNo = _normalSiraNo++;
                }
                else
                {
                    musteri.YapilacakIslem.IslemTipi = Enums.IslemTipi.Gise;
                    db.Gise.SiradakiMusteriler.Add(musteri);
                    musteri.SiraNo = _normalSiraNo++;
                }
            }
        }
    }
}
