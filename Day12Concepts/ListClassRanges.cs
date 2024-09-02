using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class ListClassRanges
    {
        List<CustomerType> listCoporateCustomers = CustomerTest.GetCustomerTypes();

        public void AddRange()
        {
            listCoporateCustomers.AddRange(listCoporateCustomers);

            foreach (CustomerType customerType in listCoporateCustomers)
            {
                Console.WriteLine("ID ={0}, Name = {1}, Salary ={2}, Type ={3}", customerType.ID, customerType.Name, customerType.Salary, customerType.Type);
            }
        }

        public void GetRange()
        {
            List<CustomerType> customers = listCoporateCustomers.GetRange(3, 2);

            foreach (CustomerType customerType in listCoporateCustomers)
            {
                Console.WriteLine("ID ={0}, Name = {1}, Salary ={2}, Type ={3}", customerType.ID, customerType.Name, customerType.Salary, customerType.Type);

            }
        }

        public void InsertRange()
        {
            CustomerType customer1 = new CustomerType()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000,
                Type = "RetailCustomer"
            };

            listCoporateCustomers.InsertRange(3,listCoporateCustomers);

            foreach (CustomerType c in listCoporateCustomers)
            {
                Console.WriteLine("ID ={0}, Name = {1}, Salary ={2}, Type ={3}", c.ID, c.Name, c.Salary, c.Type);

            }
        }

        public void RemoveRanges()
        {
            listCoporateCustomers.RemoveAll(x => x.Type == "CorporateCustomer");

            foreach (CustomerType c in listCoporateCustomers)
            {
                Console.WriteLine("ID ={0}, Name = {1}, Salary ={2}, Type ={3}", c.ID, c.Name, c.Salary, c.Type);

            }
        }

        public void RemoveAt()
        {
            listCoporateCustomers.RemoveAt(4);

            foreach (CustomerType c in listCoporateCustomers)
            {
                Console.WriteLine("ID ={0}, Name = {1}, Salary ={2}, Type ={3}", c.ID, c.Name, c.Salary, c.Type);

            }
        }
    }
}
