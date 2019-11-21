using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int firstNumberLotto;
            int secondNumberLotto;
            int thirdNumberLotto;
            int firstNumberUser;
            int secondNumberUser;
            int thirdNumberUser;
            int matchingNumbers = 0;

            firstNumberLotto = ranNumberGenerator.Next(1, 5);
            secondNumberLotto = ranNumberGenerator.Next(1, 5);
            thirdNumberLotto = ranNumberGenerator.Next(1, 5);

            Console.WriteLine("Guess three numbers");
            firstNumberUser = Convert.ToInt32(Console.ReadLine());
            secondNumberUser = Convert.ToInt32(Console.ReadLine());
            thirdNumberUser = Convert.ToInt32(Console.ReadLine());
            if(firstNumberUser == firstNumberLotto || firstNumberUser == secondNumberLotto || firstNumberUser == thirdNumberLotto)
                matchingNumbers++;
            if (secondNumberUser == firstNumberLotto || secondNumberUser == secondNumberLotto || secondNumberUser == thirdNumberLotto)
                matchingNumbers++;
            if (thirdNumberUser == firstNumberLotto || thirdNumberUser == secondNumberLotto || thirdNumberUser == thirdNumberLotto)
                matchingNumbers++;
            if (firstNumberUser == secondNumberUser && firstNumberUser == thirdNumberUser)
                matchingNumbers -= 2;
            if (firstNumberLotto == secondNumberLotto || firstNumberLotto == thirdNumberLotto)
            {
                matchingNumbers++;
                if (secondNumberLotto == thirdNumberLotto)
                    matchingNumbers++;
            }
            else if (secondNumberLotto == firstNumberLotto || secondNumberLotto == thirdNumberLotto)
            {
                matchingNumbers++;
                if (firstNumberLotto == thirdNumberLotto)
                    matchingNumbers++;
            }
            else if (thirdNumberLotto == firstNumberLotto || thirdNumberLotto == secondNumberLotto)
            {
                matchingNumbers++;
                if (firstNumberLotto == secondNumberLotto)
                    matchingNumbers++;
            }

            if (firstNumberUser == secondNumberUser || firstNumberUser == thirdNumberUser)
            {
                matchingNumbers++;
                if (secondNumberUser == thirdNumberUser)
                    matchingNumbers++;
            }
            else if (secondNumberUser == firstNumberUser || secondNumberUser == thirdNumberUser)
            {
                matchingNumbers++;
                if (firstNumberUser == thirdNumberUser)
                    matchingNumbers++;
            }
            else if (thirdNumberUser == firstNumberUser || thirdNumberUser == secondNumberUser)
            {
                matchingNumbers++;
                if (firstNumberUser == secondNumberUser)
                    matchingNumbers++;
            }

            if (firstNumberUser == secondNumberUser || firstNumberUser == thirdNumberUser)
            {
                matchingNumbers--;
                if (secondNumberUser == thirdNumberUser)
                    matchingNumbers--;
            }
            else if (secondNumberUser == firstNumberUser || secondNumberUser == thirdNumberUser)
            {
                matchingNumbers--;
                if (firstNumberUser == thirdNumberUser)
                    matchingNumbers--;
            }
            else if (thirdNumberUser == firstNumberUser || thirdNumberUser == secondNumberUser)
            {
                matchingNumbers--;
                if (firstNumberUser == secondNumberUser)
                    matchingNumbers--;
            }

            if (firstNumberLotto == secondNumberLotto || firstNumberLotto == thirdNumberLotto)
            {
                matchingNumbers--;
                if (secondNumberLotto == thirdNumberLotto)
                    matchingNumbers--;
            }else if (secondNumberLotto == firstNumberLotto || secondNumberLotto == thirdNumberLotto)
            {
                matchingNumbers--;
                if (firstNumberLotto == thirdNumberLotto)
                    matchingNumbers--;
            }else if (thirdNumberLotto == firstNumberLotto || thirdNumberLotto == secondNumberLotto)
            {
                matchingNumbers--;
                if (firstNumberLotto == secondNumberLotto)
                    matchingNumbers--;
            }
           
            if (matchingNumbers == 1)
                Console.WriteLine("Award: $10");
            else if (matchingNumbers == 2)
                Console.WriteLine("Award: $100");
            else if (matchingNumbers == 3)
            {
                if (firstNumberUser == firstNumberLotto && secondNumberUser == secondNumberLotto && thirdNumberUser == thirdNumberLotto)
                    Console.WriteLine("Award: $10,000");
                else Console.WriteLine("Award: $1,000");

            }
            else Console.WriteLine("No matches. Good luck next time!");
            Console.WriteLine($"The winning number is {firstNumberLotto}, {secondNumberLotto}, {thirdNumberLotto}");
               
        }
    }
}
