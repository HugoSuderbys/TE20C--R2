using System;

namespace Namespace_chart
{
    class Program
    {
        static void Main(string[] args)
        {
           string meddelande = "Hej på dig!";

           Console.WriteLine(meddelande);

           Console.WriteLine(meddelande[0]);

           Console.WriteLine(meddelande[10]);


           char bokstav = 'Z';

           for (int i = 0; i < 11; i++)
           {
               Console.WriteLine($"index {i}{meddelande[i]}");
           }
        }
    }
}
