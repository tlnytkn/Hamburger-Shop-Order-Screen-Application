using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.Core
{
    class Burger
    {
        public int burgerFiyati { get; set; }
        public string burgerAdi { get; set; }
        
        public override string ToString() // Override BÜyük harflerle yazdırmaya yarıyor.
        {
            return burgerAdi.ToUpper();
        }

    }
}
