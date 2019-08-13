using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, Counter, term;
            string tryMore = "Y";
            Console.WriteLine();
            while (tryMore.ToUpper() == "Y")
            {
                Console.Write("Enter the number for Mupltiply :");
                Number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the terms :");
            term = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("==================================");

                for (Counter = 1; Counter <= term; Counter++)
                {
                    Console.WriteLine(Number + " x " + Counter + " =" + Number * Counter);
                }
                Console.WriteLine();
                Console.WriteLine("==================================");
                Console.Write("Do you want to Continue (Y/N) :");
                tryMore = Console.ReadLine();
                Console.WriteLine("==================================");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


