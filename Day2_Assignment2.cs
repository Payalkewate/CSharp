using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignment2
{
    class Program
    {
        //Print Table of the given number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            long n = Convert.ToInt32(Console.ReadLine());
            for(int j=1;j<=10;j++)
            {
                Console.Write("{0}*{1}={2}\n", n, j, n * j);
            }
            Console.Read();
        }
    }
}
