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
            int numberOfBooks;
            char isHardcover;
            int tempTotal;
            const int averageCost =125;

            Console.Write("Enter the number of books: ");
            numberOfBooks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Are the text hardcover? ");
            isHardcover = Convert.ToChar(Console.ReadLine().ToUpper());
            tempTotal = numberOfBooks * averageCost;
            switch (isHardcover)
            {
                case 'Y':
                    switch (numberOfBooks)
                    {
                        case int number when (number >= 4):
                            Console.WriteLine($"The before-tax cost of the textbooks is {tempTotal + tempTotal * 20 / 100 - tempTotal * 5 / 100:c}");
                            break;
                        case int number when (number < 4):
                            Console.WriteLine($"The before-tax cost of the textbooks is {tempTotal + tempTotal * 20 / 100:c}");
                            break;
                    }
                    break;
                case 'N':
                    switch (numberOfBooks)
                    {
                        case int number when (number >= 4):
                            Console.WriteLine($"The before-tax cost of the textbooks is {tempTotal - tempTotal * 5 / 100:c}");
                            break;

                        case int number when (number < 4):
                            Console.WriteLine($"The before-tax cost of the textbooks is {tempTotal:c}");
                            break;
                    }
                    break;

            }
                        
                      

        }
    }
}
