using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class Program
    {
        static double szambekeresfuggveny(int oldalszam, string szoveg)
        {
            double szam = 0;
            bool ok = false;
            do
            {
                try
                {
                    Console.Write("{0}{1}", oldalszam, szoveg);
                    szam = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                    if ((szam < 1))
                    {
                        Console.WriteLine("Nullánál nagyobb számot adj meg!\nKérem újra a számot!");
                        ok = false;

                    }
                }
                catch
                {
                    Console.WriteLine("Nem számot adtál meg!\nKérem újra a számot!");
                    ok = false;
                }

            } while (!ok);
            return szam;
        }

        static void Main(string[] args)
        {
            double aoldal = 0, boldal = 0;
            double ker, ter;
            Console.WriteLine("Kérem a téglalap oldalait!");
            int i = 1;
            aoldal = szambekeresfuggveny(i, ". oldal: A=");
            i = 2;
            boldal = szambekeresfuggveny(i, ". oldal: B=");
            ker = 2 * (aoldal + boldal);
            ter = aoldal * boldal;
            Console.WriteLine("A téglalap kerülete = {0}\nA téglalap területe = {1}", ker, ter);
            Console.ReadKey();

        }
    }
}
