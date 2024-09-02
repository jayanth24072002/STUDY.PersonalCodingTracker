using System;

namespace Day6Concepts.ParentClass
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }     

    public class ChildClass : ParentClass
    {
        public ChildClass() :base("Derived class controlling")
        {
            Console.WriteLine("ChildClass Constructor called");
        }
    }
}
