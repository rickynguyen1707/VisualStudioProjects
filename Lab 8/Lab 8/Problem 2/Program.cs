using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            for (int i=0; i < poem.Length; i++)
            {
                Console.Write($"{poem[i]} ");
            }
        }
    }
}
