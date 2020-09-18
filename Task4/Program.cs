using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3];
            products[0] = new Product("a", 100, 4, 42);
        
            products[1] = new Product("b", 350, 6, 52);
       
            products[2] = new Product("c", 100, 1, 15);

            Shop s = new Shop("NewShop", 3, products);
            Customer c = new Customer("Tom", 1, 600);

            int x = c.MakeAnOrder(s, 42, 2);
            s.ShowRange();
            Console.WriteLine();
            s.ShowListOfOrders();
            Console.WriteLine();
            c.ShowInfo();

            int z = c.MakeAnOrder(s, 15, 1);
            s.ShowListOfOrders();
            Console.WriteLine();

            int y = c.MakeAnOrder(s, 15, 1);
            s.ShowListOfOrders();
        }
    } 
}
