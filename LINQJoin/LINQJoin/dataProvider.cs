using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoin
{
    public static class DataProvider
    {
        public static List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    ID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    Address = new Address
                    {
                        Street = "123 Main St",
                        City = "Anytown",
                        State = "CA",
                        ZipCode = "12345"
                    }
                },

                new Customer
                {
                    ID = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "987-654-3210",
                    Address = new Address
                    {
                        Street = "456 Elm St",
                        City = "Othertown",
                        State = "NY",
                        ZipCode = "54321"
                    }
                }
            };
        }

        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ID = 1,
                    ProductName = "Widget",
                    Quantity = 100
                },
                new Product
                {
                    ID = 2,
                    ProductName = "Gadget",
                    Quantity = 50
                }
            };
        }

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    CustomerID = 1,
                    ProductID = 1,
                    OrderDate = DateTime.Now,
                    DeliverDate = null,
                    Note = "Urgent delivery required"
                },
                new Order
                {
                    CustomerID = 2,
                    ProductID = 2,
                    OrderDate = DateTime.Now.AddDays(-2),
                    DeliverDate = DateTime.Now.AddDays(3),
                    Note = ""
                }
            };
        }
    }
}
