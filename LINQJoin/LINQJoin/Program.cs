using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQJoin
{
    class Program
    {
        /* 'var' használata helyett létrehozhatunk egy osztályt
        class CustomerProduct
        {
            public string CustomerName { get; set; }
            public Product Product { get; set; }
        }
         */

        static void Main(string[] args)
        {
            List<Customer> customers = DataProvider.GetCustomers();
            List<Product> products = DataProvider.GetProducts();
            List<Order> orders = DataProvider.GetOrders();


            // IEnumerable<CustomerProduct> - 'var' helyett
            var result = from order in orders
                         join customer in customers
                         on order.CustomerID equals customer.ID
                         select new // CustomerProduct - ha nem a 'var'-t használjuk, akkor kell ez a típus
                         {
                            CustomerName = customer.FirstName + " " + customer.LastName,
                            Product = (from prod in products
                                       where prod.ID == order.ProductID
                                       select prod).FirstOrDefault()
                         };

            // foreach (CustomerProduct item in result)

            foreach (var item in result)
            {
                Console.Write($"Customer: {item.CustomerName}, ");
                Console.WriteLine($"Product: {item.Product?.ProductName ?? "Product not found"}");
            }
        }
    }
}
