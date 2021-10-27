using System;

namespace Lyckhjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Skapa ett program som ska fungera som ett lyckohjul
            Console.WriteLine("Lyckohjul, du har tre försök på dig");

            //När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på

            Random generator = new Random();
            //Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev

            //Berätta också för användaren om hen vann eller förlorade
            for (var i = 0; i < 3; i++)
            {
                int slumptal = generator.Next(1, 11);

                Console.WriteLine("Välj ett tal mellan 1-10");
                int tal = int.Parse(Console.ReadLine());

                if (tal == slumptal)
                {
                    Console.WriteLine("Grattis du vann!");
                    break;
                }
                else
                {
                    Console.WriteLine("Tyvär du förlorade");
                }
            }
            //Användaren får 3 försök!
        }
    }
}
