using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=32;
            

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < vowels.Length; i++)
            {
                Console.Write($"{vowels[i]} ");
                
            }
            Console.WriteLine();
            for(int i = 0; i < vowels.Length; i++)
            {
                int vowelsnum = Convert.ToInt32(vowels[i]);
                vowelsnum = vowelsnum - 32;
                vowels[i] = Convert.ToChar(vowelsnum);
                Console.Write($"{vowels[i]} ");
            }
        }
    }
}
