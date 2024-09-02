using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day14Concepts.ExceptionHandling;
using Day14Concepts.Asynchronous;
using Day14Concepts.PartialClasses;
using Day14Concepts.Tuples;
using Day14Concepts.ConstantAndReadonly;

namespace Day14Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionHandlingExample();
            ConstantAndReadonly();
            //Asynchronous();
            //Tuple();
            //PartialClasses();
        }

        static void ExceptionHandlingExample()
        {
            Numbers numbers = new Numbers();
            numbers.ExceptionExample();
        }

        public static void ConstantAndReadonly()
        {
            ConstReadOnly constReadOnly1 = new ConstReadOnly();
            ConstReadOnly constReadOnly2 = new ConstReadOnly();
            ConstReadOnly constReadOnly3 = new ConstReadOnly();
            ConstReadOnly constReadOnly4 = new ConstReadOnly();
        }

        public static void Asynchronous()
        {
            AsynchronousExample asynchronousExample = new AsynchronousExample();
            asynchronousExample.Fun1();
            asynchronousExample.Fun2();
        }

        public static void Tuple()
        {
            TupleExample TupleExample = new TupleExample();
            TupleExample.GetEmployeeDetails();
        }

        public static void PartialClasses()
        {
            HelloClass hello = new HelloClass();
            hello.HelloWorld();
            hello.HelloWorld();
        }
    }
}
