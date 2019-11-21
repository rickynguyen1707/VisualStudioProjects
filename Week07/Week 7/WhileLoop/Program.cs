using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber;
            int counter;

            Console.WriteLine("Count to?");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            counter = 0;

            while(counter < maxNumber)
            {
                counter = counter + 1;
                Console.WriteLine(counter);
            }

        }
    }
}
