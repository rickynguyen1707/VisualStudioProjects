using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userInput;
            
            Console.WriteLine("Input a phrase: ");
            userInput = Console.ReadLine();
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] counter = new int[alphabet.Length];
            for (int i=0;i< userInput.Length; i++)
            {
                
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (alphabet[k] == userInput[i])
                    {
                        counter[k]++;
                    }
                }
            }
            for(int m = 0; m < counter.Length; m++)
            {
                Console.WriteLine(counter[m]);
            }
        }
    }
}
