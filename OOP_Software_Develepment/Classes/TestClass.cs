using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Software_Develepment.Classes
{
    class TestClass
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.SetValues("1","2","3",78,4569);
           var val = car.ReturnCurrentValueOfThecar;
           var c = car.ReturnYearOfCar;
            Console.WriteLine(car.ToString());

            var fleet = new Fleet(100);
            var car1 = new Car();
            car1.SetValues("11", "22", "33", 78, 45690);
            var car2 = new Car();
            car2.SetValues("10", "12", "43", 78, 14569);
            var car3 = new Car();
            car3.SetValues("14", "32", "03", 78, 145692);
            var car4 = new Car();
            car4.SetValues("16", "42", "3", 78, 4545);
            fleet.Add(car1);
            fleet.Add(car2);
            fleet.Add(car3);
            fleet.Add(car4);
            Console.WriteLine("total sum of car:{0:C}",fleet.CalcFleetTotalValue());

            int highest;
            int lowest;
            fleet.CalcStat(out lowest,out highest);
            Console.WriteLine("nejvyssi hodnota je:{0}",highest);
            Console.WriteLine("nejnizsi hodnota je:{0} ",lowest);

            int count, index;
           var cars = fleet.GetYearOfCars(78,out count,out index);
            foreach (var car5 in cars)
            {
                Console.WriteLine(car5);
            }
        
             
                 
        }
    }
}
