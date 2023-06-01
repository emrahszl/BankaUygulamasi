using Banka.Data.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Collections
{
    public class Islemler : BindingList<Islem>
    {
        public BireyselIslemler BireyselIslemler { get; set; } = new();

        public GiseIslemleri GiseIslemleri { get; set; } = new();

        public VipIslemler VipIslemler { get; set; } = new();
    }
}
