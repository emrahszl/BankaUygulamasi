using Banka.Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Collections
{
    public class Musteriler : BindingList<Musteri>
    {
        public VipMusteriler VipMusteriler { get; set; } = new();

        public BireyselMusteriler BireyselMusteriler { get; set; } = new();

        public NormalMusteriler NormalMusteriler { get; set; } = new();
    }
}
