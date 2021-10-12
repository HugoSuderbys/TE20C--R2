using System;

namespace Uppgift_karim_borta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("I vilket land är Angela Merkel president?");
            string svar = Console.ReadLine();
            while (svar != "tyskland")
            {
                 Console.WriteLine("Du svarade fel, försök igen");
                 svar = Console.ReadLine();
                 
            }
            Console.WriteLine("Grattis! Du svarade rätt!");
        }
    }
}
