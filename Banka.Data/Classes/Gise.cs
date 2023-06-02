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
        public Musteri? IslemYapanMusteri { get; set; } //Gişede o an işlem yapan müşteri.

        public Islemler TamamlananIslemler { get; set; } = new(); //Gişenin tamamladığı işlemler tutuluyor.

        public Musteriler SiradakiMusteriler { get; set; } = new();

        public Musteriler IslemiTamamlananMusteriler { get; set; } = new();


        public void SiradakiIslem()
        {
            IslemYapanMusteri = SiradakiMusteriler.FirstOrDefault(); //Sıradaki müşterilerin tamamını sıra numarasına göre sıralayıp ilk sıradaki müşteriyi gişe'nin müşterisine atıyor.
        }

        public void MusteriIsleminiTamamla()
        {
            switch (IslemYapanMusteri!.YapilacakIslem.IslemTipi) //Müşterinin işlemi tamamlandığında müşterinin işlem tipine göre gişenin tamamlanan işlemlerine atılıyor. Bunu yapmamızın sebebi bankanın gün sonunda gişede hangi işlem tipinde kaç adet işlem yapıldığını öğrenmek istemesinden kaynaklanıyor.
            {
                case IslemTipi.Vip:
                    IslemYapanMusteri.YapilacakIslem.Durum = IslemDurumu.Tamamlandı;
                    TamamlananIslemler.VipIslemler.Add(IslemYapanMusteri.YapilacakIslem);
                    break;
                case IslemTipi.Bireysel:
                    IslemYapanMusteri.YapilacakIslem.Durum = IslemDurumu.Tamamlandı;
                    TamamlananIslemler.BireyselIslemler.Add(IslemYapanMusteri.YapilacakIslem);
                    break;
                default:
                    IslemYapanMusteri.YapilacakIslem.Durum = IslemDurumu.Tamamlandı;
                    TamamlananIslemler.GiseIslemleri.Add(IslemYapanMusteri.YapilacakIslem);
                    break;
            }

            SiradakiMusteriler.Remove(IslemYapanMusteri); //Müşterinin işlemi tamamlandığı için sıradaki müşteriler listesinden çıkarılıyor.
            IslemiTamamlananMusteriler.Add(IslemYapanMusteri); //İşlemi tamamlanan müşterileri görüntülemek için listeye ekliyoruz.
        }
    }
}
