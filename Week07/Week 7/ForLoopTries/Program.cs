using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTries
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 10;
            const int MAX = 20;
            const int MAX_TRIES = 3;
            int userInput=0;
            int counter;

            for(counter = 0; counter <MAX_TRIES; counter++)
            {
                Console.WriteLine($"Try #{counter+1} Input a number between {MIN} and {MAX}");
                userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput >= MIN && userInput <= MAX)
                {
                    break;
                }
                
            }
            //if (userInput >= MIN && userInput <= MAX)
            if (counter != MAX_TRIES)
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
