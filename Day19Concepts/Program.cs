using System;
using System.Data;

namespace Day19Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AllOperator(); 
            //AnyOperators();
            //ContainOperators();
            //DistinctOperators();
            //ExceptOperators();
            //IntersectOperators();
            UnionOperators();
        }

        public static void AllOperator()
        {
            OperatorAllMethod operatorAllMethod = new OperatorAllMethod();
            operatorAllMethod.BasicAllQuery();
            operatorAllMethod.ComplexAllMethod();
        }

        public static void AnyOperators()
        {
            AnyOperator anyOperator = new AnyOperator();
            anyOperator.BasicAnyMethod();
            anyOperator.ComplexAnyOperator();
        }

        public static void ContainOperators()
        {
            ContainsOperator containsOperator = new ContainsOperator();
            containsOperator.BasicList();
            containsOperator.ComplexContainsOperatorMethodSyntax();
        }

        public static void DistinctOperators()
        {
            DistinctOperator distinctOperator = new DistinctOperator();
            distinctOperator.BasicDistinctOperator();
            distinctOperator.DistinctMethod();
        }

        public static void ExceptOperators()
        {
            ExceptOperator exceptOperator = new ExceptOperator();

        }

        public static void IntersectOperators()
        {
            IntersectOperator intersectOperator = new IntersectOperator();  

        }

        public static void UnionOperators()
        {
            UnionOperator unionOperator = new UnionOperator();

        }
    }
}
