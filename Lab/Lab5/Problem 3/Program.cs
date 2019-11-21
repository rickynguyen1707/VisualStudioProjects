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
            int numberOFCourse;
            string residencyStatus;
            const int domesticCostPerCourse = 325;
            const int internationalCostPerCourse = 1375;
            int tuitionCost = 0;


            Console.Write("Enter the residency status ");
            residencyStatus = Console.ReadLine();
            Console.Write("Enter the number of course ");
            numberOFCourse = Convert.ToInt32(Console.ReadLine());
            switch (residencyStatus)
            {
                case "domestic":
                    tuitionCost = numberOFCourse * domesticCostPerCourse ;
                    break;
                case "international":
                    tuitionCost = numberOFCourse * internationalCostPerCourse ;
                    break;
                
            }
            Console.WriteLine($"The tuition cost is {tuitionCost:c}");
        }
    }
}
