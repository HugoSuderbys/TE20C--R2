using System;

namespace Boolskaoperationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Åldersgränser i sverige");


            system.console.write("Hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());


            if (ålder >= 15)
            {
              Console.WriteLine("Du får köra moped!");
            }

            if (ålder >= 18)
            {
                Console.WriteLine("Du får köra bil");
            }
        }
    }
}
