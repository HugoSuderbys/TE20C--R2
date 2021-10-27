using System;

namespace Uppgift_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
        string meddelande = "Det här meddelandet är krypterat";

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
