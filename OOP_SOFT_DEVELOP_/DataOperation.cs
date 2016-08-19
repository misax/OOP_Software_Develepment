using System;
using System.IO;

namespace OOP_SOFT_DEVELOP_
{
    public static class DataOperation
    {
     // pole preferovanych zakazniku
        public static PrefferedCustomer[] PrefferedCustomers;
        //id uzivatele jako vstup
        public static string Id;

        public static void GetData()
        {
            //cteni ze souboru
            using (var reader = new StreamReader("CustomerInfo.txt"))
            {
                var index = 0;
                PrefferedCustomers = new PrefferedCustomer[5];
                while (!reader.EndOfStream)
                {
                    //ziskat radek z text souboru do pole
                    var readLine = reader.ReadLine();
                    if (readLine != null)
                    {
                        var line = readLine.Split(':');
                        var name = line[0];
                        var address = line[1];
                        var phone = line[2];
                        var id = line[3];
                        var email = line[4];
                        var spentAmount = int.Parse(line[5]);
                        var onEmailList = bool.Parse(line[6]);
                        PrefferedCustomers[index++] = new PrefferedCustomer(name, phone, address, email, id, onEmailList,
                            spentAmount);
                    }
                }
            }
        }

        public static void UpdateData()
        {
            //zapis dat do souboru
            using (var writer = new StreamWriter("CustomerInfo.txt"))
            {
                PrefferedCustomers = new PrefferedCustomer[5];
                for(int i = 0;i < 5;i++)
                {
                    //ziskat radek z text souboru do pole
                    var name = PrefferedCustomers[i].Customername;
                    var address = PrefferedCustomers[i].Address;
                    var phone = PrefferedCustomers[i].Phone;
                    var id = PrefferedCustomers[i].CustomerID;
                    var email = PrefferedCustomers[i].CustomerMail;
                    var spentAmount = PrefferedCustomers[i].CalcAmount();
                    var onEmailList = PrefferedCustomers[i].OnEmailList;
                    writer.Write("CustomerId: {0}\nName:{1}\nCustomer address:{2}\nCustomer phone:{3}" +
                                 "\nCustomer email:{4}\nCustomer spending:{5:C2}\nCustomer on email list:{6}",
                                 id,
                                 name,
                                 address,
                                 phone,
                                 email,
                                 spentAmount,
                                 onEmailList == true ? "true":"false" );
                }
            }
        }

        public static int GetId()
        {
            string enterId = string.Empty;
               bool idIsOk = false;
            do
            {
                var customIndex = 0;
                Console.Write("Put id:");
                enterId = Console.ReadLine();
                foreach (var cust in PrefferedCustomers)
                {
                    if (string.Compare(cust.CustomerID, Id, StringComparison.Ordinal) != 0)
                    {
                        idIsOk = true;
                        return customIndex;
                    }
                    else
                    {
                        idIsOk = false;
                         customIndex++;
                    }
                }
                Console.Write("Index does not exist");
            } while (idIsOk);
            return enterId[0];
        }
        //ziskat uzivatelske udaje .Pouze za predpokladu,ze zvoli volbu 1 nebo dva.
        public static string UserChoice()
        {
            var user = Console.ReadLine();
            while (user != "1" && user != "2")
            {
                Console.WriteLine("Wrong input.Try again.");
                DisplayInfo();
                user = Console.ReadLine();
            }
            return user;
        }

        public static void DisplayInfo()
        {
            Console.WriteLine("1. Dispay customer info.");
            Console.WriteLine("2. Update costumer ifo.");
            Console.WriteLine("Please enter your choice: ");
        }
    }
}