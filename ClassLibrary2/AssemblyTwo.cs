using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            base.Id = 101;
        }
    }
}
