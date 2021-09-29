using System;

namespace Nånting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hej vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name);
            Console.WriteLine("Jag heter consol");

            Console.WriteLine("Vart bor du?");
            string ort = Console.ReadLine();
            Console.WriteLine("Vad trevligt att du bor i " + ort);

            Console.WriteLine("Hur gammal är du?");
            string ålder = Console.ReadLine();
            Console.WriteLine($"Du är {ålder} år");


        }
    }
}
