using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            do
            {
                if (counter % 5 == 0)
                {
                    Console.WriteLine($"{counter}*");
                }else
                {
                    Console.WriteLine(counter);
                }
                counter++;
            } while (counter <= 20);
        }
    }
}
