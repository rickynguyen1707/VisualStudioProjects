using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char playerOneChoice;
            char playerTwoChoice;

            Console.WriteLine("Choose between rock paper and scissors");
            playerOneChoice = Convert.ToChar(Console.ReadLine().ToLower());
            playerTwoChoice = Convert.ToChar(Console.ReadLine().ToLower());
            if (playerOneChoice == playerTwoChoice)
                Console.WriteLine("Tie");
            else if (playerOneChoice == 'r')
            {
                if (playerTwoChoice == 'p')
                    Console.WriteLine("Player two wins");
                else if (playerTwoChoice == 's')
                    Console.WriteLine("Player one wins");
            }else if (playerOneChoice == 'p')
            {
                if (playerTwoChoice == 'r')
                    Console.WriteLine("Player one wins");
                else if (playerTwoChoice == 's')
                    Console.WriteLine("Player two wins");
            }else if (playerOneChoice == 's')
            {
                if (playerTwoChoice == 'r')
                    Console.WriteLine("Player two wins");
                else if (playerTwoChoice == 'p')
                    Console.WriteLine("Player one wins");
            }
        }
    }
}
