using System;

namespace Uppgift_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett omvandlingsprogram");

            string val = "";

            while (val != "3")

            {
                Console.WriteLine();
                Console.WriteLine("Välj ett av följande alternativ");
                Console.WriteLine("1. Omvandla meter till kilometer");
                Console.WriteLine("2. Omvandla kilometer till meter");
                Console.WriteLine("3. Avsluta programet");
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                    Console.WriteLine("Skriv in längd i meter");
                    double antalmeter = double.Parse(Console.ReadLine());
                    Console.WriteLine($"längden du skrev in är detsamma som {antalmeter / 1000} km");
                        break;

                    case "2":
                    Console.WriteLine("Skriv in en längd i km");
                    double antalKm = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Längden du skrev in är detsamma som {antalKm * 1000} meter");
                        break;
                        
                    case "3":
                    Console.WriteLine("Programmet avslutas...");
                        break;

                    default:
                    break;
                }
            }
            


        }
    }
}
