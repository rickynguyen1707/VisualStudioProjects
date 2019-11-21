// Nguyen Khang Nguyen - Student ID: 301098234

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            string city;
            string state;
            string zipcode;
            int quantityOfBlender;
            double priceOfBlender = 39.95;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Street address: ");
            address = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            state = state.ToUpper();
            Console.Write("Zip code: ");
            zipcode = Console.ReadLine();
            Console.Write("How many magic blenders do you want to order? ");
            quantityOfBlender = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"\nReceipt for: \n{name} \n{address} \n{city}, {state} {zipcode}");
            Console.WriteLine($"\n{quantityOfBlender} blenders ordered @$39.95 each\n\nTotal:   {(quantityOfBlender*priceOfBlender):c}");
            Console.WriteLine($"Tax:     {(quantityOfBlender * priceOfBlender) * 7 / 100:c}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Due:     {(quantityOfBlender * priceOfBlender) + (quantityOfBlender * priceOfBlender) * 7 / 100:c}\n");





        }
    }
}
