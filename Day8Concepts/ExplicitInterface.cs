using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Concepts.ExplicitInterface
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
    public class ExplicitExample : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("Interface I1 Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("Interface I2 Method");
        }
    }
}
