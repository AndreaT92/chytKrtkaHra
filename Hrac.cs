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
            ConsoleKeyInfo informaceOKlavese = Console.ReadKey();
            char znak = informaceOKlavese.KeyChar;
            while (!char.IsDigit(znak))
            {
                Console.WriteLine("Toto není číslo");
                informaceOKlavese = Console.ReadKey();
                znak = informaceOKlavese.KeyChar;
            }
            return int.Parse(znak.ToString());   
        }

    }
}
