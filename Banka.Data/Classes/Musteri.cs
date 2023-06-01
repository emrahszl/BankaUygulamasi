using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class Musteri
    {
        public Musteri(string ad, string soyad, string tcNo)
        {
            Ad = ad;
            Soyad = soyad;
            TcNo = tcNo;

            if (tcNo.StartsWith('1'))
                OncelikliMi = true;
            else OncelikliMi = false;
        }

        public string Ad { get; }

        public string Soyad { get; }

        public string TcNo { get; }

        public bool OncelikliMi { get; set; }

        public int SiraNo { get; set; }

        public Islem YapilacakIslem { get; set; } = new();
    }
}
