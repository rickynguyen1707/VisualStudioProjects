using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCourse;
            string residencyStatus;
            const int domesticRate = 325;
            const int internationalRate = 1375;

            Console.Write("Enter your residency status ");
            residencyStatus = Console.ReadLine().ToLower();
            Console.Write("Enter the number of courses ");
            numberOfCourse = Convert.ToInt32(Console.ReadLine());
            switch (residencyStatus)
            {
                case "domestic":
                    Console.WriteLine($"The tuition cost is {numberOfCourse * domesticRate:c}");
                    break;
                case "international":
                    Console.WriteLine($"The tuition cost is {numberOfCourse * internationalRate:c}");
                    break;

            }
        }
    }
}
