using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOFT_DEVELOP_
{
    class CustomerDemo
    {
        static void Main(string[] args)
        {
            do
            {
                DataOperation.GetData();
               var custIndex = DataOperation.GetId();
                DataOperation.DisplayInfo();
                if (DataOperation.UserChoice() == "1")
                {
                    Console.WriteLine(DataOperation.PrefferedCustomers[custIndex]);
                }
                if (DataOperation.UserChoice() == "2")
                {
                   DataOperation.UpdateData();
                }

            } while (true);
        }
    }
}
