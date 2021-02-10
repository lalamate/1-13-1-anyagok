using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csakszam
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            bool ok = false;
            do
            {
                try
                {
                    Console.Write("Kérek egy számot: ");
                    szam = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Nem számot adtál meg!");
                    ok = false;
                }
            } while (!ok);
            Console.WriteLine("A megadott szám: {0}", szam);
            Console.ReadKey();
        }
    }
}
