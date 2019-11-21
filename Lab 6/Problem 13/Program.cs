using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradePointAverage;
            double admissionTestScore;

            Console.Write("Enter your grade point average: ");
            gradePointAverage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your admission test score: ");
            admissionTestScore = Convert.ToDouble(Console.ReadLine());
            switch (gradePointAverage)
            {
                case double grade when grade >= 3.0:
                    switch (admissionTestScore)
                    {
                        case double score when score >= 60:
                            Console.WriteLine("Accept");
                            break;
                        default:
                            Console.WriteLine("Reject");
                            break;
                    }
                    break;
                case double grade when grade < 3.0:
                    switch (admissionTestScore)
                    {
                        case double score when score >= 80:
                            Console.WriteLine("Accept");
                            break;
                        default:
                            Console.WriteLine("Reject");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Reject");
                    break;
            }
        }
    }
}
