using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindegy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia, hogy hívnak?");
            var nev = Console.ReadLine();
            Console.WriteLine($"Oh, milyen szép név az hogy, {nev}");
            Console.WriteLine("Szerecc programozni ?");
            var valasz = Console.ReadLine();
            if (valasz.ToLower()== "igen")
            {
                Console.WriteLine("Akkor mi nagyon jó barátok leszünk");
                else
                {
                    Console.WriteLine("):");
                    Console.WriteLine("Akkor viszlát");
                }
                Console.ReadKey();
            }
        }
    }
}
