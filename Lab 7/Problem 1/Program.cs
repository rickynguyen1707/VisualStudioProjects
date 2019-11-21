using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            do
            {
                Console.Write("* ");
                counter++;
            }
            while(counter < 5);
        }
    }
}
