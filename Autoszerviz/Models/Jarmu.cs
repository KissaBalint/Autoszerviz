using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    public abstract class Jarmu
    {
        public string rendszam { get; set; }
        public int gyartasiEv { get; set; }
        public string allapot { get; set; }

        protected Jarmu(string rendszam, int gyartasiEv, string allapot)
        {
            this.rendszam = rendszam;
            this.gyartasiEv = gyartasiEv;
            this.allapot = allapot;
        }

        public abstract void SzervizVizsga();

        public override string ToString()
        {
            return $"Rendszám: {rendszam}, gyártási éve: {gyartasiEv}, állapot: {allapot}";
        }
    }
}
