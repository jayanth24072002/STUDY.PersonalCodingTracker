using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.PartialClasses
{
        public partial class HelloClass
        {
            public void HelloWorld() => Console.WriteLine("Hello world");
        }

        public partial class HelloClass
        {
            public void HelloUniverse() => Console.WriteLine("Hello world");
        }
}
