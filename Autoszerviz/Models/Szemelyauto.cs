using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    public class Szemelyauto : Jarmu
    {

        public int ajtokSzama { get; set; }

        public Szemelyauto(string rendszam, int gyartasiEv, string allapot, int ajtokSzama) : base(rendszam, gyartasiEv, allapot)
        {
            this.ajtokSzama = ajtokSzama;
        }

        public override void SzervizVizsga()
        {
            allapot = "Kész";
        }
        public override string ToString()
        {
            return base.ToString() + $", ajtók száma: {ajtokSzama}db";
        }
    }
}
