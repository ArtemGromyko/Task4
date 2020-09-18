using System;
using System.Collections.Generic;

namespace Task4
{
    class Shop
    {
        public string NameOfShop { get; set; }
        public int NumberOfProducts { get; set; }
        public Product[] Products { get; set; }
        public List<Order> ListOfOrders { get; set; }
        public Shop() { }
        public Shop(string name, int number, Product[] products)
        {
            NameOfShop = name;
            NumberOfProducts = number;
            Products = products;
            ListOfOrders = new List<Order>();
        }
        public void ShowRange()
        {
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine("productID: " + Products[i].ProductID + " name of product: " + Products[i].NameOfProduct + " price: " + Products[i].Price + " number of copies: "+ Products[i].NumberOfCopies);
            }
        }
        public void ShowListOfOrders()
        {
            for(int i = 0; i<ListOfOrders.Count; i++)
            {
                ListOfOrders[i].ShowInfo();
            }
        }
    }
}
