using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chytKrtka
{
    internal class Krtek
    {

        public int ObjevSe()
        {
            Random generator = new Random();
            int nahodneCislo = generator.Next(0, 9);
            Console.WriteLine(nahodneCislo);
            return nahodneCislo;
        }

        public bool BylJsemZasazen(int cislo, int nahodneCislo)
        {
            return cislo == nahodneCislo;
        }


    }
}
