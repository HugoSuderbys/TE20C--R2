using System;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Clear();
           // Console.WriteLine("Räkna 1 till 10");

         //   for (int i = 1; i < 11; i++)
          //  {
              //  Console.WriteLine($"Loop nr{i}");

          //  }
            
                Console.WriteLine("Skriv ett meddelande");
                string meddelande = Console.ReadLine();


                for (int i = 0; i < meddelande.Length; i++)
                {
                    Console.WriteLine(meddelande[i]);
                }
        }
    }
}
