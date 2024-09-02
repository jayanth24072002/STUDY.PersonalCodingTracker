using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class CustomerTestData
    {
        public static List<Customer> GetCustomers()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 101,
                Name = "John",
                Salary = 6000
            };

            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "Pam",
                Salary = 4000
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            return listCustomers;
        }
    }

    public class CustomerTest
    {
        public static List<CustomerType> GetCustomerTypes()
        {

            CustomerType customer1 = new CustomerType()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000,
                Type = "RetailCustomer"
            };

            CustomerType customer2 = new CustomerType()
            {
                ID = 102,
                Name = "John",
                Salary = 6000,
                Type = "RetailCustomer"
            };

            CustomerType customer3 = new CustomerType()
            {
                ID = 103,
                Name = "jay",
                Salary = 4000,
                Type = "RetailCustomer"
            };

            CustomerType customer4 = new CustomerType()
            {
                ID = 104,
                Name = "mav",
                Salary = 4000,
                Type = "CorporateCustomer"
            };

            CustomerType customer5 = new CustomerType()
            {
                ID = 105,
                Name = "clock",
                Salary = 4000,
                Type = "CorporateCustomer"
            };

            List<CustomerType> listCoporateCustomers = new List<CustomerType>();
            listCoporateCustomers.Add(customer1);
            listCoporateCustomers.Add(customer2);
            listCoporateCustomers.Add(customer3);
            listCoporateCustomers.Add(customer4);
            listCoporateCustomers.Add(customer5);

            return (listCoporateCustomers);
        }
    }
}
