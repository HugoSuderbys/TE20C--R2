using System;

namespace Kapitel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Spel - gissa ett tal mellan 1 och 100.");

            while (true)
            {
                            Random tärning = new Random();
            int slumptal = tärning.Next(1, 101);

            int räknare = 0;

            while (true)
            {
                räknare++;


                             Console.Write("Gissa ett tal (1-100)");
            int gissning = int.Parse(Console.ReadLine());

            if (gissning == slumptal)
            {
                Console.WriteLine($"Bra gissat! Du gjorde det på {räknare} försök");
                break;
            }

            if (gissning < slumptal)
            {
                Console.WriteLine("För lågt!");
            }
            else
            {
                Console.WriteLine("För högt!");
            }
            }
            }
        }
    }
}
