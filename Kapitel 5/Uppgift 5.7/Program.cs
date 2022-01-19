using System;

namespace Uppgift_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = { 1, 2, 3, 4, 5};
            int summa = 0;
            foreach (var tal in heltal)
            {
                summa += tal;
            }
Console.WriteLine(summa);

        }
    }
}
