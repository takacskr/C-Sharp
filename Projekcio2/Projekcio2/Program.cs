using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekcio1
{
    class Address
    {
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public int State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }

    class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> custList = new List<Customer>();

            // Add customers using a method
            AddCustomer(custList, "Béla", "Kiss", "bela@printcenter.hu", "06304567890", "Hungary", 12345, 1, "Budapest", "Main Street");
            AddCustomer(custList, "Zoltán", "Barnóczki", "zolib@akarmi.hu", "06705987456", "Hungary", 98765, 2, "Kazincbarcika", "Futrinka Street");
            AddCustomer(custList, "András", "Nagy", "nagyandras@google.com", "06201498745", "Sweden", 679453, 3, "Ikea", "Boloren Street");

            var result = from customer in custList
                         select new
                         {
                             Name = customer.LastName + " " + customer.FirstName,
                             Email = customer.Email,
                             Phone = customer.PhoneNumber
                         };

            foreach (var customer in result)
            {
                Console.WriteLine($"Name: {customer.Name} Email: {customer.Email} Phone: {customer.Phone}");
            }
        }

        // Method to add customers to the list
        static void AddCustomer(
            List<Customer> custList,
            string firstName,
            string lastName,
            string email,
            string phoneNumber,
            string country,
            int postalCode,
            int state,
            string city,
            string street)
        {
            Customer customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,

                Address = new Address
                {
                    Country = country,
                    PostalCode = postalCode,
                    State = state,
                    City = city,
                    Street = street
                }
            };

            custList.Add(customer);
        }
    }
}
