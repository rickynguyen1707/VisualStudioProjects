using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char mood;

            Console.Write("What is your mood today? ");
            mood = Convert.ToChar((Console.ReadLine()).ToLower());
            if (mood == 'u')
                Console.WriteLine("I feel great today!");
            else Console.WriteLine("I feel down today #$*!");
        }
    }
}
