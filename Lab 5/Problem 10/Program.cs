using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double iQScore;

            Console.Write("Enter an IQ Score ");
            iQScore = Convert.ToDouble(Console.ReadLine());
            if (iQScore < 0 || iQScore > 200)
                Console.WriteLine("ERROR");
            else if (iQScore >= 0 && iQScore < 100)
                Console.WriteLine("Below Average");
            else if (iQScore == 100)
                Console.WriteLine("Average");
            else Console.WriteLine("Above Average");
           
            
        }
    }
}
