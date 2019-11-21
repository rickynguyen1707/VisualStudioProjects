using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradePointAverage;
            double admissionTestScore;

            Console.Write("Enter your high school grade point average: ");
            gradePointAverage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your admission test score: ");
            admissionTestScore = Convert.ToDouble(Console.ReadLine());
            if (gradePointAverage >= 3.0 && admissionTestScore >= 60)
            {
                Console.WriteLine("Accept");
            }
            else if (gradePointAverage < 3.0 && admissionTestScore >= 80)
                Console.WriteLine("Accept");
            else Console.WriteLine("Reject");
        }
    }
}
