using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv din summa ");
            string summatext = Console.ReadLine();
            
            int summa = 0;
            for (int i = 0; i < summatext.Length; i++)
            {
                char siffra = summatext[i];
                Console.WriteLine(siffra);

                int siffratal = int.Parse(siffra.ToString());

                summa += siffratal;
            }

            Console.WriteLine($"Summan av talet {summatext} är {summa}");
        }
    }
}
