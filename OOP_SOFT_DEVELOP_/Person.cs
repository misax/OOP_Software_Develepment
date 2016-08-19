namespace OOP_SOFT_DEVELOP_
{
    public abstract class Person
    {
        public  string Customername { get; set; }
        public string Phone { get; set; }
        public  string Address { get; set; }
        public abstract int SpendAmount { get; set; }

        protected Person(string name,string phone,string address)
        {
            Customername = name;
            Phone = phone;
            Address = address;
        }

        protected virtual double CalcAmount()
        {
            return SpendAmount;
        }
    }
}