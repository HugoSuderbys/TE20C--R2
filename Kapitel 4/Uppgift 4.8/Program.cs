using System;

namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            string tal = Console.ReadLine();

            bool finns3Eller7 = false;

            for (int i = 0; i < tal.Length; i++)
            {
                if (tal[i] == '3' || tal[i] == '7')
                {
                    finns3Eller7 = true;
                }
            }

            if (finns3Eller7)
            {
                Console.WriteLine("Talet innehåller minst en 3:a och/eller 7:a");
            }
            else
            {
                Console.WriteLine("Det finns inte någon 3:a eller 7:a i talet.");
            }
        }
    }
}
