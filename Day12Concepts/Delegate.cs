using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class Delegates
    {
        public void DelegateWithList()
        {
           List<Customer> listCustomers = CustomerTestData.GetCustomers();

            Console.WriteLine("Before Sorting");
           
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.ID);
            }

            listCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

            Console.WriteLine("After Sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.ID);
            }
        }
    }
}
