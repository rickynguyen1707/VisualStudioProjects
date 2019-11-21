using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpperEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string aString;

            Console.WriteLine("Enter a string");
            aString = Console.ReadLine();

            Console.WriteLine($"To Upper {aString.ToUpper()}");
            Console.WriteLine($"To Lower {aString.ToLower()}");
        }
    }
}
