using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.Interface
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }
    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Interface print1 Method");
        }

        public void Print2()
        {
            Console.WriteLine("Interface print2 Method");
        }
    }
}
