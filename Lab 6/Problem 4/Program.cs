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
            double iQScore;

            Console.Write("Enter an IQ Score: ");
            iQScore = Convert.ToDouble(Console.ReadLine());
            switch (iQScore)
            {
                case double iQ when (iQ > 0 && iQ < 100):
                    Console.WriteLine("below average");
                    break;
                case double iQ when (iQ == 100):
                    Console.WriteLine("average");
                    break;
                case double iQ when (iQ > 100 && iQ < 200):
                    Console.WriteLine("above average");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
