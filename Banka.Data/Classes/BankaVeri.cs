using Banka.Data.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class BankaVeri   //Bankanın tüm bilgilerinin tutulduğu yer.
    {   
        public Islemler Islemler { get; set; } = new();

        public Numarator Numarator { get; set; } = new();

        public Gise Gise { get; set; } = new();

        public Musteriler Musteriler { get; set; } = new();
    }
}
