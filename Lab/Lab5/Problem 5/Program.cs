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
            string day;
            string message = "something";

            Console.Write("Enter a day of the week ");
            day = Console.ReadLine();
            switch (day)
            {
                case "Sun":
                    message = "Home";
                    break;
                case "Mon":
                    message = "Work";
                    break;
                case "Tue":
                    message = "Work";
                    break;
                case "Wed":
                    message = "Home";
                    break;
                case "Thu":
                    message = "Work";
                    break;
                case "Fri":
                    message = "Work";
                    break;
                case "Sat":
                    message = "Work";
                    break;
            }
            Console.WriteLine(message);
       
        }
    }
}
