using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Concepts.MethodOverriding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }

    public class  DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am an Base Class Print Method");
        }
    }
}
