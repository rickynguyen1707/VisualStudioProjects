using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Nguyen Khang Nguyen 301098234
   Quiz 2*/
namespace DogBoarding
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogsWeight;
            int numberOfDaysBoarded;
            const double costPerPoundPerDay = 0.50;

            Console.WriteLine("Enter the weight of the dog");
            dogsWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of days to be boarded");
            numberOfDaysBoarded = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The total price for boarding is {costPerPoundPerDay * dogsWeight * numberOfDaysBoarded:c}");
           
        }
    }
}
