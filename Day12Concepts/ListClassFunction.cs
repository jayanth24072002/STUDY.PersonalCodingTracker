using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class ListClassFunctions
    {
        List<Customer> listCustomers = CustomerTestData.GetCustomers();

        public void Exists()
        {
            if (listCustomers.Exists(cust => cust.Name.StartsWith("P")))
            {
                Console.WriteLine("Customer 3 object exists in the list");
            }
            else
            {
                Console.WriteLine("Customer 3 object does not  exists in the list");

            }
        }
        public void Find()
        {
            Customer c = listCustomers.Find(cust => cust.Salary > 5000);
            Console.WriteLine("Id={0},Name={1},Salary{2}", c.ID, c.Name, c.Salary);
        }

        public void FindLast()
        {
            Customer c = listCustomers.FindLast(cust => cust.Salary > 5000);
            Console.WriteLine("Id={0},Name={1},Salary{2}", c.ID, c.Name, c.Salary);
        }

        public void FindAll()
        {
            List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 5000);

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id={0},Name={1},Salary{2}", customer.ID, customer.Name, customer.Salary);
            }
        }

        public void FindIndex()
        {
            int index = listCustomers.FindIndex(2,cust => cust.Salary > 5000);
            Console.WriteLine("Index = " + index);
        }

        public void Dictionary()
        {
            Dictionary<int, Customer> dictionary = listCustomers.ToDictionary(x => x.ID);

            foreach (KeyValuePair<int, Customer> kvp in dictionary)
            {
                Console.WriteLine("Key =" + kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("Id={0},Name={1},Salary{2}", c.ID, c.Name, c.Salary);
            }
        }
    }
}
