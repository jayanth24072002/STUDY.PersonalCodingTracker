using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.ConstantAndReadonly
{
    public class ConstReadOnly
    {
        int number = 0;
        public ConstReadOnly()
        {
            number++;
            Console.WriteLine("For first object : ", number);
        }
    }
}
