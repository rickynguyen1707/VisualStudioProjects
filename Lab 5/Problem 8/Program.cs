using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            int lawnMowingFee;
            int total;
            int payingTimes;

            Console.Write("Enter the length of the lawn: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the lawn: ");
            width = Convert.ToDouble(Console.ReadLine());
            area = width * length;
            if (area < 400)
            {
                lawnMowingFee = 25;
                Console.WriteLine($"The weekly mowing fee is {lawnMowingFee:c}");
            }else if (area >=400 && area < 600)
            {
                lawnMowingFee = 35;
                Console.WriteLine($"The weekly mowing fee is {lawnMowingFee:c}");
            }
            else
            {
                lawnMowingFee = 50;
                Console.WriteLine($"The weekly mowing fee is {lawnMowingFee:c}");
            }
            total = lawnMowingFee * 20;
            Console.WriteLine($"The total fee for the 20-week season {total:c}");
            Console.WriteLine("\nEnter the number of times you want to pay\n(1)once\n(2)twice\n(3)20 times per season");
            payingTimes = Convert.ToInt32(Console.ReadLine());
            if (payingTimes == 1)
            {
                Console.WriteLine($"Total payment: {total:c}");
            }else if(payingTimes == 2)
            {
                Console.WriteLine($"Each payment amount: {total / 2 + 5:c}");
                Console.WriteLine($"Total payment: {total:c}");
            }else if(payingTimes == 3)
            {
                Console.WriteLine($"Each payment amount: {total / 20 + 3:c}");
                Console.WriteLine($"Total payment: {total:c}");
            }
        }
    }
}
