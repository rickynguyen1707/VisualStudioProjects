using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string provinceCode;
            double itemCost;
            const double onRate = 0.14;
            const double pqRate = 0.13;
            const double otherRate = 0;

            Console.Write("Enter your 2-letter province code: ");
            provinceCode = Console.ReadLine().ToUpper();
            Console.Write("Enter the cost of the item: ");
            itemCost = Convert.ToDouble(Console.ReadLine());
            if (provinceCode == "ON")
                Console.WriteLine($"The tax rate on your product is {itemCost * onRate:c}");
            else if (provinceCode == "PQ")
                Console.WriteLine($"The tax rate on your product is {itemCost * pqRate:c}");
            else Console.WriteLine($"The tax rate on your product is {itemCost * otherRate:c}");

        }
    }
}
