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
            string dayOfTheWeek;

            Console.Write("Enter a day of the week: ");
            dayOfTheWeek = Console.ReadLine();
            switch (dayOfTheWeek)
            {
                case "Sun":
                    Console.WriteLine("Home");
                    break;
                case "Mon":
                    Console.WriteLine("Work");
                    break;
                case "Tue":
                    Console.WriteLine("Work");
                    break;
                case "Wed":
                    Console.WriteLine("Home");
                    break;
                case "Thu":
                    Console.WriteLine("Work");
                    break;
                case "Fri":
                    Console.WriteLine("Work");
                    break;
                case "Sat":
                    Console.WriteLine("Work");
                    break;
            }
        }
    }
}
