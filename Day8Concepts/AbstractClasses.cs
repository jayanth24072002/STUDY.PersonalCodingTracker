using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.AbstractClasses
{
    public abstract class Customer
    {
        public abstract void Print();
    }

    public class AbstractExample : Customer
    {
        public override void Print()
        {
            Console.WriteLine("print method");
        }
    }
}
