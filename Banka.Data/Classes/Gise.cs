using Banka.Data.Collections;
using Banka.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class Gise
    {
        public Musteri? Musteri { get; set; } //Gişe de o an işlem yapan müşteri.

        public Islemler TamamlananIslemler { get; set; } = new(); //Gişenin tamamladığı işlemler tutuluyor.

        public SiradaBekleyenMusteriler SiradakiMusteriler { get; set; } = new(); //Gişenin sıradaki müşterileri tutuluyor.

        public void SiradakiIslem()
        {
            if (SiradakiMusteriler.Count == 0) //Sırada müşteri olup olmadığı kontrol ediliyor.
                Console.WriteLine("Sırada bekleyen müşteri yok!");
            else
            {
                if (SiradakiMusteriler.Any(x => x.OncelikliMi)) //Sıradaki müşterilerde öncelikli olan var mı diye kontrol ediliyor. Varsa if'e giriyor yoksa else kısmına geçiyor.
                {
                    var oncelikliler = SiradakiMusteriler.Where(x => x.OncelikliMi).OrderBy(x => x.SiraNo).ToList(); //Sıradaki müşteriler listesinde öncelikli olanları sıra numarasına göre listeyelip oncelikliler içerisinde topluyoruz.
                    Musteri = oncelikliler.FirstOrDefault(); //oncelikliler listesinde sıra numarası en küçük olan müşteriyi getiriyor.
                }
                else
                {
                    Musteri = SiradakiMusteriler.OrderBy(x => x.SiraNo).ToList().FirstOrDefault(); //Sıradaki müşterilerin tamamını sıra numarasına göre sıralayıp ilk sıradaki müşteriyi gişe'nin müşterisine atıyor.
                }
            }
        }

        public void MusteriIsleminiTamamla()
        {
            if (Musteri == null) //Gişede o an müşteri olup olmadığı kontrol ediliyor.
                Console.WriteLine("Gişede müşteri yok!");
            else
            {
                switch (Musteri.YapilacakIslem.IslemTipi) //Müşterinin işlemi tamamlandığında müşterinin işlem tipine göre gişenin tamamlanan işlemlerine atılıyor. Bunu yapmamızın sebebi bankanın gün sonunda gişede hangi işlem tipinde kaç adet işlem yapıldığını öğrenmek istemesinden kaynaklanıyor.
                {
                    case IslemTipi.Vip:
                        TamamlananIslemler.VipIslemler.Add(Musteri.YapilacakIslem);
                        break;
                    case IslemTipi.Bireysel:
                        TamamlananIslemler.BireyselIslemler.Add(Musteri.YapilacakIslem);
                        break;
                    default:
                        TamamlananIslemler.GiseIslemleri.Add(Musteri.YapilacakIslem);
                        break;
                }

                SiradakiMusteriler.Remove(Musteri); //Müşterinin işlemi tamamlandığı için sıradaki müşteriler listesinden çıkarılıyor.
            }
        }
    }
}
