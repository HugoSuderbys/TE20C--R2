using System;

namespace menyprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enkelt menyprogram");

            while (true)
            {
                Random tärning = new Random();
                int slumptal = tärning.Next(1,4);

                 Console.WriteLine("Välj ett av följande alternativ");
                 Console.WriteLine("Väljer du sten? (1)");
                 Console.WriteLine("Väljer du sax? (2)");
                 Console.WriteLine("Väler du påse? (3)");
                 Console.WriteLine("Vill du avsluta? (4)");
                 string valstring = Console.ReadLine();
                 

                 if (valstring == "4" )
                 {
                     break;
                 }

                    int val = int.Parse(valstring);

                 if (val == slumptal)
                 {
                     Console.WriteLine("Du vinner");
                 }
                 else
                 {
                     
                 }
            }
        }
    }
}
