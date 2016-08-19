namespace OOP_Software_Develepment.Classes
{
    public class Car
    {
        private  string _model;
        private  string _make;
        private  string _registration;
        private  int _yearOfRegistration;
        private int _currentValue;

    

        public Car()
        {
           SetValues(_model,_make,_registration,_yearOfRegistration,_currentValue);
        }

        public void SetValues(string model, string make, string registration, int yearOfRegistration, int currentValue)
        {
             _model = model;
            _make = make;
            _registration = registration;
            _yearOfRegistration = yearOfRegistration;
            _currentValue = currentValue;
        }

        public int ReturnCurrentValueOfThecar => _currentValue;       
        public int ReturnYearOfCar => _yearOfRegistration;
        public override string ToString()
        {
            return string.Format("Model of The car:{0}\nMake:{1}\nRegistration:{2}\nYear of registration of car:{3}\ncurrent value of a car:{4}\n",
                _model,_make,_registration,_yearOfRegistration,_currentValue);
        }
    }
}