using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DifferenceBeetweenTwoPoints
{
    public class Coordinates
    {
        public double CalculateCoordintes(double x1, double y1, double x2, double y2)
        {          
            var temp = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp + temp2);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var coord = new Coordinates();
            try
            {
                Console.Write("Input two points x1 and y1 coordinates");
                var x1 = double.Parse(Console.ReadLine());
                var y1 = double.Parse(Console.ReadLine());
                Console.Write("Input two points x2 and y2 coordinates");
                var x2 = double.Parse(Console.ReadLine());
                var y2 = double.Parse(Console.ReadLine());
                var resultOfCoord = coord.CalculateCoordintes(x1, x2, y1, y2);
                Console.WriteLine("point is {0}.poits is {1},point is {2},point is [{3}]", x1, y1, y2, x2);
                Console.WriteLine("Distance beetween two points is {0:F}", resultOfCoord);
            }
            finally
            {
                Thread.Sleep(2000);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Zadana data jsou otestovana a jsou spravna");
            }
        }
    }
}
