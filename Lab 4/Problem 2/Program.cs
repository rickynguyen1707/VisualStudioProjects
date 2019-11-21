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
            char status;

            Console.Write("Enter salesperson's status: ");
            status = Convert.ToChar((Console.ReadLine()).ToUpper());
            if (status == 'S')
                Console.WriteLine("Senior salesperson is paid $400 a week");
            else Console.WriteLine("Junior salesperson is paid $275 a week");
        }
    }
}
