using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Customer
    {
        public string CustomerName { get; set; }
        public int ID { get; set; }
        public double PaymentBalance { get; set; }
        public Customer() { }
        public Customer(string name, int id, double balance)
        {
            CustomerName = name;
            ID = id;
            PaymentBalance = balance;
        }
        public int MakeAnOrder(Shop shop, int productID, int numberOfCopies)
        {
            int index = -1;
            for (int i = 0; i < shop.Products.Length; i++)
                if (shop.Products[i].ProductID == productID)
                    index = i;
            if (index == -1)
            {
                Console.WriteLine("wrong product id");
                return 1;
            }
            else if (shop.Products[index].NumberOfCopies < numberOfCopies)
            {
                Console.WriteLine("not enough copies of product");
                return 2;
            }
            else if (shop.Products[index].Price*shop.Products[index].NumberOfCopies > PaymentBalance)
            {
                Console.WriteLine("not enough money");
                return 3;
            }
            else
            {
                shop.Products[index].NumberOfCopies -= numberOfCopies;
                PaymentBalance -= shop.Products[index].Price * shop.Products[index].NumberOfCopies;
                shop.ListOfOrders.Add(new Order(shop.ListOfOrders.Count, shop.Products[index], numberOfCopies));
                return 0;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("name: "+CustomerName+" id: "+ID+" PaymentBalance: "+PaymentBalance);
        }
    }
}
