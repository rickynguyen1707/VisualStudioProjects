// Nguyen Khang Nguyen - Student ID: 301098234

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double highSchoolGradePointAverage;
            double admissionTestScore;

            Console.Write("Enter the high school grade point average: ");
            highSchoolGradePointAverage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the admission test score: ");
            admissionTestScore = Convert.ToDouble(Console.ReadLine());
            if ((highSchoolGradePointAverage >= 3.0 && admissionTestScore >= 60) || (highSchoolGradePointAverage < 3.0 && admissionTestScore >= 80))
                Console.WriteLine("Accept");
            else Console.WriteLine("Reject");

        }
    }
}
