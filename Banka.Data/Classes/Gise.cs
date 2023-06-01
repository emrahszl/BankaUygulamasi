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
        public Musteri? Musteri { get; set; }

        public Islemler TamamlananIslemler { get; set; } = new();

        public SiradaBekleyenMusteriler SiradakiMusteriler { get; set; } = new();

        public void SiradakiIslem()
        {
            if (SiradakiMusteriler.Count == 0)
                Console.WriteLine("Sırada bekleyen müşteri yok!");
            else
            {
                if (SiradakiMusteriler.Any(x => x.OncelikliMi))
                {
                    var oncelikliler = SiradakiMusteriler.Where(x => x.OncelikliMi).OrderBy(x => x.SiraNo).ToList();
                    Musteri = oncelikliler.FirstOrDefault();
                }
                else
                {
                    Musteri = SiradakiMusteriler.OrderBy(x => x.SiraNo).ToList().FirstOrDefault();
                }
            }
        }

        public void MusteriIsleminiTamamla()
        {
            if (Musteri == null)
                Console.WriteLine("Gişede müşteri yok!");
            else
            {
                switch (Musteri.YapilacakIslem.IslemTipi)
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

                SiradakiMusteriler.Remove(Musteri);
            }
        }
    }
}
