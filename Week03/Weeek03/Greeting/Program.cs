using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Hi, what is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name );
           

        }
    }
}
