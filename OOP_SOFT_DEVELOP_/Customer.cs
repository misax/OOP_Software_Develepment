namespace OOP_SOFT_DEVELOP_
{
    public class Customer : Person
    {
        public string CustomerID { get; set; }
        public  string CustomerMail { get; set; }

        public override int SpendAmount { get; set; }

        public bool OnEmailList { get; set; }
        public Customer(string name, string phone, string address,string email,string id,bool onmailList,int spend) 
            : base(name, phone, address)
        {
            CustomerID = id;
            CustomerMail = email;
            OnEmailList = onmailList;
            SpendAmount = spend;

        }

        public virtual double CalcAmount()
        {
            return SpendAmount;
        }
    }
}