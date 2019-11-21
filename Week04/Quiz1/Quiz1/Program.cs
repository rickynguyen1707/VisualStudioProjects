using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds;
            double ounces;
            double grams;
            int kilogram;
            string userInput;

            Console.WriteLine("Please enter weight in pounds and ounces.");
            Console.WriteLine("pounds?");
            userInput = Console.ReadLine();
            pounds = Convert.ToDouble(userInput);
            Console.WriteLine("ounces?");
            userInput = Console.ReadLine();
            ounces = Convert.ToDouble(userInput);

            pounds = pounds + ounces / 16;
            grams = pounds * 443.592 ;

            kilogram = (int)grams/1000;
            // kilograms = (grams-grams%1000)/1000;
        
            grams = grams % 1000;
            
            
            
            Console.WriteLine($"{pounds}lb {ounces}oz is {kilogram}kg {grams}g");


            
        }
    }
}
