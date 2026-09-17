using Autoszerviz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz
{
    internal class Program
    {
        static List<Jarmu> jarmuk = new List<Jarmu>();
        static void Main(string[] args)
        {

            jarmuk.Add(new Teherauto("ABC-123", 2018, "Javításra vár", 10));
            jarmuk.Add(new Teherauto("DEF-123", 2020, "Kész", 15));
            jarmuk.Add(new Teherauto("ABC-123", 2015, "Javításra vár", 8));
            jarmuk.Add(new Szemelyauto("XYZ-111", 2019, "Javításra vár", 4));
            jarmuk.Add(new Szemelyauto("XYZ-222", 2021, "Kész", 5));
            jarmuk.Add(new Szemelyauto("XYZ-333", 2017, "Javításra vár", 3));


            foreach (Jarmu jarmu in jarmuk)
            {
                Console.Write("Nyomjon egy entert a kezdéshez!");
                Console.ReadKey();
                if(jarmu.allapot == "Javításra vár")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("A javítás elkezdődött!");
                    Console.WriteLine("Adatok: " + jarmu.ToString());
                    Console.WriteLine("A javítás befejezve!");
                    jarmu.SzervizVizsga();
                    Console.WriteLine("Adatok: " + jarmu.ToString());
                    Console.WriteLine("--------------------------------------------");
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Ez a jármű kész!");
                    Console.WriteLine("Adatok: " + jarmu.ToString());
                    Console.WriteLine("--------------------------------------------");
                    
                }
                
            }

        }
    }
}
