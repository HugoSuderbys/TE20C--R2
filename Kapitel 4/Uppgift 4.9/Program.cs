using System;

namespace Uppgift_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många kvadrattal vill du skriva ut?");
            int antalKvadrater = int.Parse(Console.ReadLine());

            for (int i = 1; i <= antalKvadrater; i++)
            {
                Console.WriteLine($"{i}*{i} = {i*i}");
            }
        }
    }
}
