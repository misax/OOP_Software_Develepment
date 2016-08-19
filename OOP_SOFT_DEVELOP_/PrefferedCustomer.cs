namespace OOP_SOFT_DEVELOP_
{
    public class PrefferedCustomer : Customer
    {
        private readonly decimal DiscountLevel;
        public PrefferedCustomer(string name, string phone, string address, string email, string id, bool onmailList,decimal discount) 
            : base(name, phone, address, email, id, onmailList,0)
        {
            DiscountLevel = SetDiscount(discount);
        }

        public override double CalcAmount()
        {
            return SpendAmount - GetDiscount();
        }

        public decimal SetDiscount(decimal discount)
        {
            switch ((int)discount)
            {
                case 500:
                    return 0.5m;
                case 1000:
                    return 0.6m;
                case 1500:
                    return 0.8m;
                case 2000:
                    return 1.0m;
                default:
                    return 0.1m;
            }
        }

        public double GetDiscount()
        {
            return SpendAmount*(double) DiscountLevel;
        }

        public override string ToString()
        {
            return string.Format("CustomerId: {0}\n" +
                                 "Name:{1}\n"+
                                 "Customer address:{2}\n"+
                                 "Customer phone:{3}\n"+
                                 "Customer email:{4}\n"+
                                 "Customer spending:{5:C2}\n"+
                                 "Customer on email list:{6}",
                                 CustomerID,
                                 Customername,
                                 Address
                                 ,Phone,
                                 CustomerMail
                                 ,CalcAmount(),
                                 OnEmailList);
        }
    }
}