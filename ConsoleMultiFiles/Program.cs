using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Prime.DecisionPrime pNum = new Prime.DecisionPrime();
            Console.WriteLine("Please input integer number.");
            int num = int.Parse(Console.ReadLine());
            if (pNum.IsPrime(num))
                Console.WriteLine(num.ToString() + " is prime number!\n");
            else
                Console.WriteLine(num.ToString() + " is NOT prime number!\n");

            Console.WriteLine("press any key");
            Console.ReadKey();
        }
    }
}
