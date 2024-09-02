using System;

namespace Day18Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WhereMethod();
            //OfTypeMethod();
            //OrderByAscending();
            //OrderByDescending();
            ReverseMethods();
        }

        public static void WhereMethod()
        {
            WhereMethod whereMethod = new WhereMethod();
            //whereMethod.WhereQuerySyntax();
            //whereMethod.WhereMethodSyntax();
            //whereMethod.StringWherequerySyntax();
            whereMethod.StringWhereMethodSyntax();
        }

        public static void OfTypeMethod()
        {
            OfTypeMethod ofTypeMethod = new OfTypeMethod();
            //ofTypeMethod.OfTypeQuerySyntax();
            ofTypeMethod.OfTypeMethodSyntax();
        }

        public static void OrderByAscending()
        {
            OrderByMethod orderByMethod = new OrderByMethod();
            //orderByMethod.OrderByAescendingMethodSyntax();
            //orderByMethod.OrderByAescendingQuerySyntax();
            //orderByMethod.StringOrderByQuerySyntax();
            //orderByMethod.StringOrderByMethodSyntax();
            orderByMethod.AscendingOrder();
        }

        public static void OrderByDescending()
        {
            OrderByDesending orderByDesending = new OrderByDesending();
            //orderByDesending.OrderByDesendingQuerySyntax();
            //orderByDesending.OrderByDesendingMethodSyntax();
            //orderByDesending.StringOrderByQuerySyntax();
            //orderByDesending.StringOrderByMethodSyntax();
            orderByDesending.ComplexDesendingOrder();
        }

        public static void ReverseMethods()
        {
            ReverseMethod reverseMethod = new ReverseMethod();
            //reverseMethod.StringReverseMethod();
            reverseMethod.BasicReverseMethod();
        }
    }
}
