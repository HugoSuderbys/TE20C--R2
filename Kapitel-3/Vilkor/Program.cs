using System;

namespace Vilkor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användarn om ålder
            Console.WriteLine("Hur gammal är du? (heltal)");
            int ålder = int.Parse (Console.ReadLine());

            // Om åldern är större än 18 " Du får ta körkort!

            if (ålder >= 18)
            {
                Console.WriteLine("Du får ta körkort!");
            }

            

            //Om åldern är 15 heller högre -> "Du får ta moppekörkort!"

            if (ålder >= 15)
            {
                Console.WriteLine("Du får ta moppekörkort!");

            }

            Console.WriteLine("Vad heter ABBAs senaste album");
            string låt = Console.ReadLine();

            if (låt == "Voayge" || låt == "voyage")

            //Sista tp frågan

            Console.Write("Vem missade straffen i matchen England-Frankrike?(Efternamn)");
            string (spelare == "Mbappe")

            Console.WriteLine("Bra, du är en expert");

            Console.WriteLine("Fel! det var Mbappe");

            Console.WriteLine("Bra svarat!");

            Console.WriteLine("Fel! Albumet heter Voyage");

        }
    }
}

