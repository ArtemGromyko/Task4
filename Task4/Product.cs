using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Product
    {
        public string NameOfProduct { get; set; }
        public int ProductID { get; set; }
        public double Price { get; set; }
        public int NumberOfCopies { get; set; }
        public Product() { }
        public Product(string name, double price, int number, int id)
        {
            NameOfProduct = name;
            Price = price;
            NumberOfCopies = number;
            ProductID = id;
        }
        public void ShowInfo()
        {
            Console.WriteLine("NameOfProduct: "+NameOfProduct+" Price: "+Price);
        }
    }
}
