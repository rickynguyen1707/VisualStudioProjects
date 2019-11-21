// Nguyen Khang Nguyen - Student ID: 301098234
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
            int side1=1;
            int side2=1;
            int hypotenuse=1;

            Console.WriteLine("Side1\t\tSide2\t\tHypotenuse");
            do
            {
                do
                {
                    do
                    {

                        if (side1 * side1 + side2 * side2 == hypotenuse * hypotenuse)
                        {
                            Console.WriteLine($"{side1}\t\t{side2}\t\t{hypotenuse}");
                        }
                        side1++;
                    } while (side1 <= 500);
                    side1 = 1;
                    side2++;
                } while (side2 <= 500 );
                side2 = 1;
                hypotenuse++;
            } while (hypotenuse <= 500);

        }
    }
}
