using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = new int[] { 100, 90, 80, 70};
            double average;
            int sum = 0;

            
            //test[0] = 100;
            //test[1] = 90;
            //test[2] = 80;
            //test[3] = 70;

            for (int i=0; i<test.Length; i++)
            {
                sum += test[i];
            }
            average = (double)sum / test.Length;

            Console.WriteLine(average);
        }
    }
}
