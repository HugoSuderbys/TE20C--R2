using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Vad heter sveriges tredje största stad?");
            string[] städer = new string[3];
            städer[0] = "Stockholm";
            städer[1] = "Göteborg";
            städer[2] = Console.ReadLine();
            
            if (städer[2] == "Malmö")
            {
                System.Console.WriteLine($"{städer[0]} {städer[1]} {städer[2]}");
            }
            else 
            {
                Console.WriteLine("Fel");
            }
            string[] länder = {"Sverige", "Finland", "Danmark", "Norge"};
            länder [0] = "Tyskland";

            foreach (var land in länder)
            {
                Console.WriteLine(land);
            }
        }
    }
}
