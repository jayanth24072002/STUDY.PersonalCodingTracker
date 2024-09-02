using System;

namespace AssemblyOne
{
   public class AssemblyOneClass1
    {
       protected internal int Id = 101;
    }
    
    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 assemblyOneClass1 = new AssemblyOneClass1();
            Console.WriteLine(assemblyOneClass1.Id);

        }
    }
}
