using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Assignmen3
{
    class Program
    {
        //ask user to delete key
        static void Main(string[] args)
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>();

            myDict.Add(1, "Dog");
            myDict.Add(2, "Cat");
            myDict.Add(3, "Rabbit");
            myDict.Add(4, "Fish");
            myDict.Add(5, "Lion");
            myDict.Add(6, "Cow");

            Console.WriteLine("Total key/value pair " + myDict.Count);

            Console.WriteLine("Enter number from 1 to 6 which you have to remove: ");
            int n = Convert.ToInt32(Console.ReadLine());
            myDict.Remove(n);

            Console.WriteLine("After remove operation Total key/value pairs: " + myDict.Count);
            Console.Read();
        }
    }
}
