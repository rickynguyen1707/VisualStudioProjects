using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageLength;
            int numberOfHouses;
            string userInput;

            Console.Write("What is the average wire length required for a home? ");
            userInput = Console.ReadLine();
            averageLength = Convert.ToDouble(userInput);

            Console.Write("What is the number of houses? ");
            userInput = Console.ReadLine();
            numberOfHouses = Convert.ToInt32(userInput);

            Console.WriteLine($"The total length of wire required for {numberOfHouses} houses is {averageLength * numberOfHouses}");



        }
    }
}
