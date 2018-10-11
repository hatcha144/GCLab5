using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            long  i,num1, fact=1;
            string restart;

            do
            {
                Console.WriteLine("Please enter an integer from 1 to 10");
                num1 = long.Parse(Console.ReadLine());

                for (i = 1; i <= num1; i++)

                {
                    fact = fact * i;
                }

                Console.WriteLine("The factorial of " + num1 + " is: " + fact);
                Console.WriteLine("Do you wish to continue? (Y or N");
                restart = Console.ReadLine();

            } while (restart.ToLower() == "y");









        }

       

   
    }
}
