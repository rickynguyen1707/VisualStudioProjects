using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int textbookCost = 125;
            int numberOfBook;
            const double premium = 20/100;
            const double discount = 5 / 100;
            double beforeTaxCost=0;

            Console.WriteLine("Enter the number of textbooks");
            numberOfBook = Convert.ToInt32(Console.ReadLine());
            switch (numberOfBook)
            {
                case int book when book >= 4:
                    beforeTaxCost = (numberOfBook * textbookCost)*(1+premium-discount);
                    break;
                case int book when book < 4:
                    beforeTaxCost = (numberOfBook * textbookCost)*(1+premium);
                    break;
                
            }
            Console.WriteLine($"The total cost of textbooks before tax is {beforeTaxCost:c}");

        }
    }
}
