using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ord Räknare");

            Console.Write("Ange en mening");

            string mening = Console.ReadLine();

            string[] orden = mening.Split(' ');

            foreach (var ord in orden)
            {
                Console.Write(ord);
            }
            Console.WriteLine($"Antal ord i mening är {orden.Length}");

            string nymening = string.Join('/', orden);
            Console.Write(nymening);
        }
    }
}
