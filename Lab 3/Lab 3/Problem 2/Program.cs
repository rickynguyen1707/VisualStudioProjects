using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double score;

            Console.Write("Enter your score: ");
            score = Convert.ToDouble(Console.ReadLine());
            if (score >= 70)
                Console.WriteLine("Pass");
            else Console.WriteLine("Fail");
        }
    }
}
