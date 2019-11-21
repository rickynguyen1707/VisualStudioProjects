using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);

            Console.Write("Guess the number: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            if (userGuess < randomNumber)
                Console.WriteLine("Too low");
            else if (userGuess == randomNumber)
                Console.WriteLine("Correct");
            else Console.WriteLine("Too high");
            Console.WriteLine($"The random number is {randomNumber}");
        }
    }
}
