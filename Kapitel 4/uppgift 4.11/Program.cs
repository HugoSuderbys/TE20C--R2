using System;

namespace uppgift_4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är Europas folkrikaste land?");
            string svar = Console.ReadLine();
            int antalGissningar = 1;

            while (svar != "Tyskland")
            {
                if (antalGissningar >= 5)
                {
                    Console.WriteLine("Dina gissningar är slut");
                    break;
                }
                Console.WriteLine("Fel svar, försök igen");
                svar = Console.ReadLine();
                antalGissningar++;
            }

            if (svar == "Tyskland")
            {
                Console.WriteLine("Ditt svar är rätt!");
            }
        }
    }
}
