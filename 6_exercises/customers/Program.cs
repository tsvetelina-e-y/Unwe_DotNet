using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            bool exit = false;

            while (!exit)
            {
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 4: exit = true; break;
                        case 1: AddListOfCustomers(customers); break;
                        case 2: PrintListOfCustomers(customers); break;
                        case 3: DeleteCustomer(customers); break;

                    }
                }
            }



        }

        public static void AddListOfCustomers(List<Customer> customersList)
        {
            int id = customersList.Count > 0 ? customersList.Select(c => c.Id).Max() : 0;

            Console.WriteLine("How many customers you will be adding?");
            int countCustomers = int.Parse(Console.ReadLine());

            Customer customer;

            for (int i = 0; i < countCustomers; i++)
            {
                customer = new Customer();
                customer.Id = ++id;

                Console.WriteLine("Customer {0} name", i + 1);
                customer.Name = Console.ReadLine();

                Console.WriteLine("Customer {0} address", i + 1);
                customer.Address = Console.ReadLine();

                Console.WriteLine("Customer {0} phone", i + 1);
                customer.Phone = Console.ReadLine();

                customersList.Add(customer);

            }
        }

        public static void PrintListOfCustomers(List<Customer> customersList)
        {
            Console.WriteLine("The list contains {0} clients", customersList.Count);

            customersList.ForEach(c =>
            {
                Console.WriteLine("Id {0}, Name {1}, Address {2}, Phone {3}", c.Id, c.Name, c.Address, c.Phone);
            });
        }

        public static void DeleteCustomer(List<Customer> customersList)
        {

            PrintListOfCustomers(customersList);

            Console.WriteLine("Select an id to delete");
            int id = int.Parse(Console.ReadLine());

            Customer customerToRemove = customersList.Where(c => c.Id == id).FirstOrDefault();

            customersList.Remove(customerToRemove);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
