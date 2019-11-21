using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int test0;
            //int test1;
            //int test2;
            //int test3;
            int[] test = new int[4];
            double average;

            //test0 = 100;
            //test1 = 90;
            //test2 = 80;
            //test3 = 70;
            test[0] = 100;
            test[1] = 90;
            test[2] = 80;
            test[3] = 70;

            average = (test[0] + test[1] + test[2] + test[3]);

            Console.WriteLine(average);
        }
    }
}
