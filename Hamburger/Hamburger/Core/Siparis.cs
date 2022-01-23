using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.Core
{
    class Siparis
    {
        string Malzemeler;
        public MenuSecim menuSecim { get; internal set; }
        public Burger burger { get; internal set; }
        public object icecek { get; internal set; }
        public decimal adet { get; internal set; }
        public List<string> Malzeme { get; set; }

        decimal araToplam=0;

        public decimal AraToplam
        {
            get
            {
                araToplam = ((burger.burgerFiyati + menuSecim.menuBuyutmeFiyati + Malzeme.Count()*5) * adet);
                return araToplam;
            }
        }

        public override string ToString()
        {
            foreach (string malzememiz in Malzeme)
            {
                Malzemeler += malzememiz;
            }
            if (Malzemeler == null)
            {
                Malzemeler = "";
            }
            return burger.burgerAdi + " " + menuSecim.menuAdi + " " + Malzemeler+" "+AraToplam;
        }

    }
}
