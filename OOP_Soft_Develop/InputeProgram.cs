using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Soft_Develop
{
    class InputeProgram
    {
        static void Main(string[] args)
        {
            var item = string.Empty;
            var number = string.Empty;
            var quantity = 0;
            var price = 0.0 ;
            try
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter: Item Description:");
                item = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Enter Item Number:");
                number = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Quantity:");
                quantity = int.Parse(Console.ReadLine());
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter Unit Price:");
                price = double.Parse(Console.ReadLine());              
            }
            catch
            {
                throw new ArgumentException("Vlozene hodnoty jsou neplatne");
            }
        
                Console.WriteLine("First Invoice:");
                Console.WriteLine(new Invoice(item, price, quantity));

                Console.WriteLine("Second Invoice:");
                Console.WriteLine(new Invoice(item, price));

                Console.WriteLine("Third Invoice:");
                Console.WriteLine(new Invoice(number, price, item, quantity));

                Console.WriteLine("Last Invoice:");
             var invoice = new Invoice(number, price, item, quantity);
              var complete = invoice.CompleteOut();
             Console.WriteLine(complete);
        }
    }
}
