using System;
using System.Collections.Generic;

namespace Projekcio1
{
    class Address
    {
        public string? Country { get; set; }
        public int? PostalCode { get; set; }
        public int? State { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
    }

    class Customer
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Address? Address { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                FirstName = "Béla",
                LastName = "Kiss",
                Email = "bela@printcenter.hu",
                PhoneNumber = "06304567890",
            };

            customer1.Address = new Address
            {
                Country = "U.S.A.",
                PostalCode = 12345,
                State = 3,
                City = "Los Angeles",
                Street = "Main Street"
            };

            Customer customer2 = new Customer
            {
                FirstName = "Zoltán",
                LastName = "Barnóczki",
                Email = "zolib@akarmi.hu",
                PhoneNumber = "06705987456",
            };

            customer2.Address = new Address
            {
                Country = "Hungary",
                PostalCode = 98765,
                State = 2,
                City = "Kazincbarcika",
                Street = "Pöttyös Street"
            };

            Customer customer3 = new Customer
            {
                FirstName = "András",
                LastName = "Nagy",
                Email = "nagyandras@google.com",
                PhoneNumber = "06201498745",
            };

            customer3.Address = new Address
            {
                Country = "Sweden",
                PostalCode = 679453,
                State = 1,
                City = "Ikea",
                Street = "Boloren Street"
            };

            List<Customer> custList = new List<Customer>();

            custList.Add(customer1);
            custList.Add(customer2);
            custList.Add(customer3);

            var result = from customer in custList
                         group customer by new
                         {
                             customer?.Address?.Country,
                             customer?.Address?.State
                         }
                         into customerGroup
                         select customerGroup;

            foreach (var group in result)
            {
                Console.WriteLine($"{group.Key.Country}, {group.Key.State}");

                foreach (var customer in group)
                {
                    Console.WriteLine($"--{customer.FirstName} {customer.LastName}");
                }
            }
        }
    }
}
