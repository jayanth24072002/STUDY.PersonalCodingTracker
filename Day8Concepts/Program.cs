using System;
using Interface = Day8Concepts.Interface;
using Day8Concepts.ExplicitInterface;
using AbstractClasses = Day8Concepts.AbstractClasses;
using Day8Concepts.DiamondProblem;
using Day8Concepts.MultipleInheritance;

namespace Day8Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface();
            ExplicitInterface();
            //AbstractClasses();
            //DiamondProblem();
            //MultipleInheritance();
        }

        public static void Interface()
        {
            Interface.Customer customer = new Interface.Customer();
            customer.Print1();
            customer.Print2();
        }

        public static void ExplicitInterface()
        {
            ExplicitExample ecplicitExample = new ExplicitExample();
            //ecplicitExample.InterfaceMethod();
            ((I1)ecplicitExample).InterfaceMethod();
            ((I2)ecplicitExample).InterfaceMethod();
        }

        public static void AbstractClasses()
        {
            AbstractClasses.Customer customer = new AbstractClasses.AbstractExample();
            customer.Print();
        }

        public static void DiamondProblem()
        {
            //D.d = new D();
            //D.Print();
        }

        public static void MultipleInheritance()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}
