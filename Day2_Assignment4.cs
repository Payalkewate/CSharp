using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignment4
{
    class Program
    {
        enum Days
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thur,
            Fri,
            Sat
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number 1 to 7");
            int day = Convert.ToInt32(Console.ReadLine());
            day--;
            Days myday = new Days();
            myday = (Days)day;
            switch (myday)
            {
                case Days.Mon:
                    Console.WriteLine("Monday");
                    break;
                case Days.Tue:
                    Console.WriteLine("Tuesday");
                    break;
                case Days.Wed:
                    Console.WriteLine("Wednesday");
                    break;
                case Days.Thur:
                    Console.WriteLine("Thursday");
                    break;
                case Days.Fri:
                    Console.WriteLine("Friday");
                    break;
                case Days.Sat:
                    Console.WriteLine("Saturday");
                    break;
                case Days.Sun:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
            Console.Read();
        }
    }
}
