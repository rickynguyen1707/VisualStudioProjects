using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);
            char computerChoice='a';
            if (randomNumber == 1)
            {
                computerChoice = 'r';
            }else if (randomNumber == 2)
            {
                computerChoice = 'p';
            }else if (randomNumber == 3)
            {
                computerChoice = 's';
            }
            Console.WriteLine("Choose between rock, paper, or scissors");
            userInput = Convert.ToChar(Console.ReadLine().ToLower());
            if (userInput  == computerChoice)
                Console.WriteLine("Tie");
            else if (userInput == 'r')
            {
                if (computerChoice  == 'p')
                    Console.WriteLine("Computer wins");
                else if (computerChoice == 's')
                    Console.WriteLine("You win");
            }
            else if (userInput == 'p')
            {
                if (computerChoice == 'r')
                    Console.WriteLine("You win");
                else if (computerChoice == 's')
                    Console.WriteLine("Computer wins");
            }
            else if (userInput == 's')
            {
                if (computerChoice == 'r')
                    Console.WriteLine("Computer wins");
                else if (computerChoice == 'p')
                    Console.WriteLine("You win");
            }
            Console.WriteLine(computerChoice);
        }
    }
}
