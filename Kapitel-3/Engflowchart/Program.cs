using System;
using System.Text;
namespace Engflowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("Engineering Flowchart");

            Console.Write("Does it move? (yes or no)");
            string answer1 = Console.ReadLine();
            if (answer1 == "yes")

  
            
            {
                Console.WriteLine("Should it move? (yes or no)");
                string answer2 = Console.ReadLine();
                if (answer2 == "yes")
                
                {
                    Console.WriteLine("USe duct tape!  😂");
                }
                else
                {
                    Console.WriteLine("No Problem! 😁");
                }
                
            }
            else
            {
                Console.WriteLine("Should it move! (yes or no)");
                string answer3 = Console.ReadLine();
                if (answer3  == "no")
                {
                    Console.WriteLine("No problem! 😆");
                }
                else
                {
                    Console.WriteLine(" Use wd-40 😇");
                }
            }
            
        }
    }
}
