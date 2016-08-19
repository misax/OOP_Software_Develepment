using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace OOP_Software_Develepment.Classes
{
    public class Fleet
    {
        private Car[] _cars;
        private int _carsCount;
        public Fleet(int count)
        {
            _cars = new Car[count];
            _carsCount = 0;
        }

        public void Add(Car car)
        {
            _cars[_carsCount++] = car;
           
        }

        public int CalcFleetTotalValue()
        {
            var total = 0;
            for (int i = 0; i < _carsCount; i++)
            {
                total += _cars[i].ReturnCurrentValueOfThecar;
            }
            return total;
        }

        public void CalcStat(out int leastValue,out int highestValue)
        {
            leastValue = _cars[0].ReturnCurrentValueOfThecar;
            highestValue = _cars[0].ReturnCurrentValueOfThecar;
            for (int i = 0; i < _carsCount; i++)
            {
                if (_cars[i].ReturnCurrentValueOfThecar.CompareTo(leastValue) < 0)
                {
                    leastValue = _cars[i].ReturnCurrentValueOfThecar;
                }
                else if (_cars[i].ReturnCurrentValueOfThecar.CompareTo(leastValue) > 0)
                {
                    highestValue = _cars[i].ReturnCurrentValueOfThecar;
                }
            }
        }

        public IEnumerable<Car> GetYearOfCars(int year,out int count,out int index)
        {
             count = 0;
             index = 0;
            for (int i = 0; i < _carsCount; i++)
            {             
                if (_cars[i].ReturnYearOfCar.Equals(year))
                {
                     count++;
                }
            }
           Car[] carYears = new Car[count];     
            for (int i = 0; i < _carsCount; i++)
            { 
                    carYears[index++] = _cars[i];
            }
            return carYears.Where(x => x.ReturnYearOfCar.Equals(year)).Select(x => x);
        }
    }
}