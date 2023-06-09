﻿using Banka.Data.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class BankaVeri   //Bankanın tüm bilgilerinin tutulduğu yer.
    {
        public BankaVeri()
        {
            Numarator = new Numarator(this);
        }

        public Islemler Islemler { get; set; } = new();

        public Numarator Numarator { get; set; }

        public Gise Gise { get; set; } = new();

        public Musteriler Musteriler { get; set; } = new();
    }
}
