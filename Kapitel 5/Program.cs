using System;

namespace Kapitel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumpa fram en fråga");

            //Skriv up korten(Array)
            string[] korten = {
            "När uppfördes Verdi?", 
            "vem van fotbolls em 1984?",
            "Vem skrev Frankenstein?",
            "Vad är 5 + 5?",
            "när startades andra världskriget",
            "vem är president i USA"};

            //Kasta tärningen
            Random tärning = new Random();
            int slumptal = tärning.Next(0, 6);

            //Skriv ut tärningsslaget
            Console.WriteLine($"Tärningen slog {slumptal}");

            Console.WriteLine($"Fråga 2: {korten[2]}");
        }
    }
}
