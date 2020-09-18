using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Order
    {
        public int OrderID { get; set; }
        public Product OrderedProduct { get; set; }
        public int NumberOfOrderedCopies { get; set; }
        public Order() { }
        public Order(int id, Product product, int numberOfCopies)
        {
            OrderID = id;
            OrderedProduct = product;
            NumberOfOrderedCopies = numberOfCopies;

        }
        public void ShowInfo()
        {
            Console.WriteLine("OrderId: "+ OrderID+" OrderedProduct id: "
            +OrderedProduct.ProductID+" OrdereProduct price: "
            + OrderedProduct.Price+" Number of copies: "+NumberOfOrderedCopies);
        }
    }
}
