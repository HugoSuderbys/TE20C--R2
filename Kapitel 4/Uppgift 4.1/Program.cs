using System;

namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är världens folkrikaste land?");

           string svar = Console.ReadLine();
           while (svar != "kina")
           {
               Console.WriteLine("Du svarade fel, försök igen");
               svar = Console.ReadLine();
               
           }
           Console.WriteLine(" Grattis du svarade rätt");
            
        }
    }
}
