using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoLoopTries
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 10;
            const int MAX = 20;
            const int MAX_TRIES = 3;
            int userInput;
            int counter = 0;

            do
            {
                counter++;
                Console.WriteLine($"Try #{counter} Input a number between {MIN} and {MAX}");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            //while (!(userInput >= MIN && userInput <= MAX));
            while ((userInput < MIN || userInput > MAX) && counter < MAX_TRIES);


            if (userInput >= MIN && userInput <= MAX)
            {
                Console.WriteLine($"You Input {userInput}");
            }
            else
            {
                Console.WriteLine("Sorry your input is invalid");
            }
            

            

        }
    }
}
