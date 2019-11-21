using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string provinceCode;

            Console.WriteLine("Enter your province code: ");
            provinceCode = Console.ReadLine().ToUpper();
            if (provinceCode == "ON")
                Console.WriteLine("You live in Ontario");
            else Console.WriteLine("You do not live in Ontario");

        }
    }
}
