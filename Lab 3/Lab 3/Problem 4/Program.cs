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
            string domesticOrNot;
            const int domesticBelowFour = 425;
            const int domesticAboveFour = 350;
            const int foreignBelowFour = 1225;
            const int foreignAboveFour = 1175;
            int numberOfCourse;

            Console.Write("Are you a domestic student? ");
            domesticOrNot = Console.ReadLine().ToUpper();
            if (domesticOrNot == "Y")
            {
                Console.Write("How many course are you taking? ");
                numberOfCourse = Convert.ToInt32(Console.ReadLine());
                if (numberOfCourse < 5)
                    Console.WriteLine($"Your tuition cost is {numberOfCourse * domesticBelowFour:c}");
                else Console.WriteLine($"Your tuition cost is {numberOfCourse * domesticAboveFour:c}");

            }
            else
            {
                Console.Write("How many course are you taking? ");
                numberOfCourse = Convert.ToInt32(Console.ReadLine());
                if (numberOfCourse < 5)
                    Console.WriteLine($"Your tuition cost is {numberOfCourse * foreignBelowFour:c}");
                else Console.WriteLine($"Your tuition cost is {numberOfCourse * foreignAboveFour:c}");
            }
        }
    }
}
