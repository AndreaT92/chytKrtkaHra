using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chytKrtka
{
    internal class Hrac
    {
        public int Zasahni()
        {
            string zadaneCislo = Console.ReadLine();
            int cislo;
            bool jeCislo = int.TryParse(zadaneCislo, out cislo);
                while (!jeCislo)
            {
                Console.WriteLine("Toto neni cislo");
                zadaneCislo = Console.ReadLine();
                jeCislo = int.TryParse(zadaneCislo, out cislo);
            }
            return cislo;
        }

    }
}
