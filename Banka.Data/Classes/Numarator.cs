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
        private static int _normalSiraNo; //Normal müşteriler içinse 0'dan başlıyor. 

        public void SiraVer(Musteri musteri)
        {
            musteri.OncelikliMi = db.VipMusteriler.Any(x => x.TcNo == musteri.TcNo) ? true : false; //Banka gelen müşterinin tipine girilen tc no'ya göre karar vermektedir. Eğer numaratörden girilen tc bankanın veritabanındaki müşteriler içerisinde varsa vip müşteri olduğuna karar veriliyor. Buna göre müşterinin öncelikli mi değil mi olduğu atanıyor.

            if (musteri.OncelikliMi) //Müşteri öncelikliyse yapacağı işlemin tipi vip olarak atnıyor ve gişenin sıradaki müşterilerine eklenerek uygun sıra numarası veriliyor.
            {
                musteri.YapilacakIslem.IslemTipi = Enums.IslemTipi.Vip;
                db.Gise.SiradakiMusteriler.Add(musteri);
                musteri.SiraNo = _vipSiraNo++;
            }
            else //Müşteri öncelikli değilse aynı şekilde yapacağı işlem tipine göre atama yapılıp gişenin sıradaki müşterilerine ekleniyor ve uygun sıra numarası veriliyor.
            {
                if (db.BireyselMusteriler.Any(x => x.TcNo == musteri.TcNo))
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
