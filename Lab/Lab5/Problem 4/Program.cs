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
            int iqScore;
            
            string message;
            

            Console.Write("Enter an IQ score ");
            iqScore = Convert.ToInt32(Console.ReadLine());
            switch (iqScore)
            {
                case int iq when (iq>=0 && iq<100):
                    message = "below average";
                    break;
                case int iq when (iq == 100):
                    message = "average";
                    break;
                case int iq when (iq > 100 && iq <= 200):
                    message = "above average";
                    break;
                default:
                    message = "ERROR";
                    break;
            }
            Console.WriteLine(message);                     
        }
    }
}
