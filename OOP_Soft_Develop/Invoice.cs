using System;

namespace OOP_Soft_Develop
{
    public class Invoice
    {      
        public string Number { get; set; }
        public double UnitPrice { get; set; }
        public string Decription { get; set; }
        public int Quantity { get; set; }

        public Invoice(string desc,double unit,int quantity = 5)
        {
            Decription = desc;
            UnitPrice = unit;
            Quantity = quantity;
        }

        public Invoice(string num,double price,string description,int quatity)
        {
            Number = num;
            UnitPrice = price;
            Decription = description;
            Quantity = quatity;
        }

        public double CalcUnitPriceTotalCost()
        {
            if (Math.Abs(UnitPrice) < 0)
            {
                return -1;
            }
            else
            {
                return UnitPrice*Quantity;
            }
        }

        public override string ToString()
        {
            var id = (Number == null) ? "" : "Item num: " + Number + "\n";
            return string.Format("\n{0}\nDescription:{1},\nTotal cost:{2:C2}\n",id,
                Decription, CalcUnitPriceTotalCost());
        }

        public string CompleteOut()
        {
            return string.Format("Item description {0}\n"
                                 + "Item number {1}\n"
                                 + "Qty purchased {2}\n"
                                 + "Unit price {3:C2}\n" +
                                 "Total cost {4:C2}",
                                 Decription, Number, Quantity,UnitPrice ,CalcUnitPriceTotalCost()
                                );
        }
    }
}