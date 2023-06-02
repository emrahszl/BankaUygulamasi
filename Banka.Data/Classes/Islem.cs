using Banka.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Data.Classes
{
    public class Islem
    {
        public IslemTipi IslemTipi { get; set; }

        public IslemDurumu Durum { get; set; }

        public override string ToString()
        {
            return $"{IslemTipi} {Durum}";
        }
    }
}
