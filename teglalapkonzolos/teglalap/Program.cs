using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class Program
    {
        static void Main(string[] args)
        {
            double aoldal=0,boldal=0;//téglalap oldalai
            double ker, ter;//téglalap kerülete, területe
            bool ok = false;//logikai változó
            Console.WriteLine("Kérek a téglalap oldalait!");//üzenet           
                do//ciklus
                {
                    try//adatellenőrzés, ha jó adatot adunk meg
                    {
                        Console.Write("Kérem az A oldalt: ");
                        aoldal = Convert.ToDouble(Console.ReadLine());
                        ok = true;
                    }
                    catch//hibás adat esetén hibaüzenetet kapunk
                    {
                        Console.WriteLine("Nem számot adtál meg!\nKérem újra a számot!");
                        ok = false;
                    }
                } while (!ok);//ciklus amíg nem ok, vagyis ha számot adunk meg akkor vége
            do//ciklus
            {
                try//adatellenőrzés, ha jó adatot adunk meg
                {
                    Console.Write("Kérem a B oldalt: ");
                    boldal = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch//hibás adat esetén hibaüzenetet kapunk
                {
                    Console.WriteLine("Nem számot adtál meg!\nKérem újra a számot!");
                    ok = false;
                }
            } while (!ok);//ciklus amíg nem ok, vagyis ha számot adunk meg akkor vége
            ker=(aoldal+boldal)*2;
            ter = aoldal * boldal;
            Console.WriteLine("A téglalap kerülete= {0}\nA téglalap területe = {1}", ker, ter);
            Console.ReadKey();
        }
    }
}
