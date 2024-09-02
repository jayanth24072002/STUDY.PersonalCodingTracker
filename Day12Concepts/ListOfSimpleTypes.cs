using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day12Concepts
{
    public class ListOfSimpleTypes
    {
        List<Customer> customers = CustomerTestData.GetCustomers();

        public void NumberSort()
        {
            List<int> numbers = new List<int>() { 1, 8, 2, 4, 3, 5, 6, 9, 7 };

            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("Numbers After sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            Console.WriteLine("Alphabets in desending order");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void AlphabetSort()
        {

            List<string> alphabets = new List<string>() { "B","A","C","E","D","F" };

            
            Console.WriteLine("Alphabets before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Sort();

            Console.WriteLine("Numbers After sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();
            Console.WriteLine("Alphabets in desending order");

            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
        }
    }
}

