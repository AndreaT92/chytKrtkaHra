using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chytKrtka
{
    internal class Hra
    {
        private int casovyLimit;

        public Hra(int casovyLimit)
        {
            this.casovyLimit = casovyLimit;
        }

        public void SpustSe()
        { 
        Krtek krtek = new Krtek();
        Hrac hrac = new Hrac();
            Console.WriteLine("Začíná hra chyť krtka (čísla 0 až 9)!");
            Console.WriteLine($"Máš {casovyLimit} sekund na stisknutí co nejvíce čísel.");
            DateTime zacatek = DateTime.Now;
            DateTime konec = zacatek.AddSeconds(casovyLimit);

            int pocetStisknuti = 0;
            while (DateTime.Now < konec)
            {
                int nahodneCislo = krtek.ObjevSe();
                int zasah = hrac.Zasahni();

                if (krtek.BylJsemZasazen(nahodneCislo, zasah))
                {
                    pocetStisknuti++;
                    Console.WriteLine($"Správný zásah! Celkový počet zásahů: {pocetStisknuti}");

                }
                else { Console.WriteLine("Nesprávný zásah."); }
                

            }
            Console.Clear();
            Console.WriteLine($"Hra skončila! Stihl(a) jsi stisknout {pocetStisknuti} čísel!");



                }



    }
}
