using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class  ListCollectionClass 
    {
        List<Customer> customers = CustomerTestData.GetCustomers();

        public void ListCollection()
        {
            Customer customer = customers[0];
            Console.WriteLine("Id={0},Name={1},Salary{2}", customer.ID, customer.Name, customer.Salary);

        }

        public void ListCollectionUsingFor()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id={0},Name={1},Salary{2}", customer.ID, customer.Name, customer.Salary);
            }
        }

        public void Insert()
        {
            Customer customer = new Customer()
            {
                ID = 119,
                Name = "Pam",
                Salary = 4000
            };
            customers.Insert(0, customer);

            foreach (Customer c in customers)
            {
                Console.WriteLine(c.ID);
            }
        }
    }
}
