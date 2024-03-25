using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = DataProvider.GetCustomers();
            List<Product> products = DataProvider.GetProducts();
            List<Order> orders = DataProvider.GetOrders();

            var result = from order in orders
                         join customer in customers
                         on order.CustomerID equals customer.ID
                         select new
                         {
                             CustomerName = customer.FirstName + " " + customer.LastName,
                             Product = (from prod in products
                                        where prod.ID == order.ProductID
                                        select prod).FirstOrDefault()
                         };

            foreach (var item in result)
            {
                Console.Write($"Customer: {item.CustomerName}, ");
                Console.WriteLine($"Product: {item.Product?.ProductName ?? "Product not found"}");
            }
        }
    }
}
