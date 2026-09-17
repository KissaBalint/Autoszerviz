using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz.Models
{
    internal class Teherauto : Jarmu
    {

        public int maxTerheles { get; set; }
        public Teherauto(string rendszam, int gyartasiEv, string allapot, int maxTerheles) : base(rendszam, gyartasiEv, allapot)
        {
            this.maxTerheles = maxTerheles;
        }

        public override void SzervizVizsga()
        {
            allapot = "Kész"; 
        }
        public override string ToString()
        {
            return base.ToString() + $", max terhelése: {maxTerheles}kg";
        }
    }
}
