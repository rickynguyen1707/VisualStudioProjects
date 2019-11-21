using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsiusDegree;
            double fahrenheitDegree;
            string userInput;

            Console.WriteLine("Put in the number of degree in Farenheit");
            userInput = Console.ReadLine();
            fahrenheitDegree = Convert.ToDouble(userInput);

            celsiusDegree = ((fahrenheitDegree - 32) * 5) / 9;
            Console.WriteLine($"The converted degree in Celsius is {celsiusDegree}");


        }
    }
}
