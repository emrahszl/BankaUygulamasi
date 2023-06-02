using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class Musteri
    {
        public Musteri(string tcNo)
        {
            TcNo = tcNo;
        }

        //Bir banka müşterisinin genel özellikleri
        public string? Ad { get; set; }

        public string? Soyad { get; set; }

        public string TcNo { get; }

        public bool OncelikliMi { get; set; }

        public int SiraNo { get; set; }

        public Islem YapilacakIslem { get; set; } = new();

        public void SiraAl(Numarator numarator)
        {
            numarator.SiraVer(this);
        }
    }
}
