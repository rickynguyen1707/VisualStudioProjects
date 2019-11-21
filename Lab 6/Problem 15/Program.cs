using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            int mowingFee;
            int choice;

            Console.WriteLine("Enter the length of the lawn: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the lawn: ");
            width = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            switch (area)
            {
                case double controlArea when (controlArea > 0 && controlArea < 400):
                    mowingFee = 25;
                    Console.WriteLine($"Weekly mowing fee: {mowingFee:c}\nTotal fee for 20-week season: {mowingFee * 20:c}");
                    break;
                case double controlArea when (controlArea >= 400 && controlArea < 600):
                    mowingFee = 35;
                    Console.WriteLine($"Weekly mowing fee: {mowingFee:c}\nTotal fee for 20-week season: {mowingFee * 20:c}");
                    break;
                default:
                    mowingFee = 50;
                    Console.WriteLine($"Weekly mowing fee: {mowingFee:c}\nTotal fee for 20-week season: {mowingFee * 20:c}");
                    break;
            }
            Console.WriteLine("How many times do you want to pay?\n(1) once\n(2) twice\n(3) 20 times");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"You chose to make 1 payment of {mowingFee * 20:c}");
                    break;
                case 2:
                    Console.WriteLine($"You chose to make 2 payment of {mowingFee * 20 / 2:c}\nTotal lawn-mowing fee: {(mowingFee * 20/2+5)*2:c}");
                    break;
                case 3:
                    Console.WriteLine($"You chose to make 20 payment of {mowingFee * 20 / 20+3:c}\nTotal lawn-mowing fee: {(mowingFee+3) * 20:c}");
                    break;

            }
        }
    }
}
