using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;

            Console.WriteLine("Enter a message");
            message = Console.ReadLine();
            if (message.Length > 140)
                Console.WriteLine("The message is too long");
        }
    }
}
