using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] obama = { "Barack", "Hussein", "Obama" };

            PrintElements(obama);
        }
        static void PrintElements(string[] obamaname)
        {
            for (int i = 0; i < obamaname.Length; i++)
            {
                Console.WriteLine(obamaname[i]);
            }
        }
    }
}
