using System;

namespace Day20Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TakeOperators();
            //TakeWhileOperators();
            //SkipOperators();
            //SkipWhileOperator();
            //FirstAndFirstDefaultOperation();
            //LastAndLastOrDefaultOperation();
            SingleAndSingleOrDefaultOperation();
        }

        public static void TakeOperators()
        {
            TakeOperator takeOperator = new TakeOperator();
            takeOperator.TakeMethod();
        }

        public static void TakeWhileOperators()
        {
            TakeWhileOperator takeWhileOperator = new TakeWhileOperator();
            //takeWhileOperator.TakeWhileMethod();
            takeWhileOperator.StringsTakeWhileMethod();
        }

        public static void SkipOperators()
        {
            SkipOperator skipOperator = new SkipOperator();
            skipOperator.SkipOperatorExample();
        }

        public static void SkipWhileOperator()
        {
            SkipWhile skipWhile = new SkipWhile();
            //skipWhile.IntegerUsingSkipWhile();
            skipWhile.StringUsingSkipWhile();
        }

        public static void FirstAndFirstDefaultOperation()
        {
            FirstAndFirstDefault firstAndFirstDefault = new FirstAndFirstDefault();
            //firstAndFirstDefault.BasicFirstVsFirstDefault();
            firstAndFirstDefault.ComplexFirst();
        }

        public static void LastAndLastOrDefaultOperation()
        {
            LastAndLastOrDefault lastAndLastOrDefault = new LastAndLastOrDefault();
            lastAndLastOrDefault.LastVsLastOrDefault();
        }

        public static void SingleAndSingleOrDefaultOperation()
        {
            SingleAndSingleOrDefault singleAndSingleOrDefault = new SingleAndSingleOrDefault(); 
            singleAndSingleOrDefault.SingleVsSingleOrDefault();
        }
    }
}
