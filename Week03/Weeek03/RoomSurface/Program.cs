using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomSurface
{
    class Program
    {
        // This program calculates the surface area in metre squares from the width and length in metres provided by user 
        static void Main(string[] args)
        {
            double width;
            double length;
            string userInput;

            Console.WriteLine("What is the width of the room?");
            userInput = Console.ReadLine();
            width = Convert.ToDouble(userInput);

            Console.WriteLine("What is the lenth of the room?");
            userInput = Console.ReadLine();
            length = Convert.ToDouble(userInput);

            Console.WriteLine($"The surface area of the room is: {width*length} metre squares");
                                 
        }
    }
}
