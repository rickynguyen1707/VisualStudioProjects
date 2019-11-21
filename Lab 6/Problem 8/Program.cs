using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pinePrice = 100;
            const int oakPrice = 225;
            const int mahoganyPrice =310 ;
            string choice;

            Console.WriteLine("Choose the wood for the table to be manufatured of (Pine, Oak,Mahogany)");
            choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "pine":
                    Console.WriteLine($"Pine table costs {pinePrice:c}");
                    break;
                case "oak":
                    Console.WriteLine($"Oak table costs {oakPrice:c}");
                    break;
                case "mahogany":
                    Console.WriteLine($"Mahogany table costs {mahoganyPrice:c}");
                    break;
            }
        }
    }
}
