using System;

namespace Day17Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkQuery();
            //Extension();
            //SelectMethod();
            SelectManyMethods();
        }

        public static void LinkQuery()
        {
            LinqQueryMethods linqQueryMethods = new LinqQueryMethods();
            //linqQueryMethods.QuerySyntax();
            //linqQueryMethods.MethodSyntax();
            linqQueryMethods.MixedSyntax();
        }

        public static void Extension()
        {
            ExtensionMethods extensionMethods = new ExtensionMethods();
            //extensionMethods.ExtentionString();
            extensionMethods.ExtentionInt();
        }

        public static void SelectMethod()
        {
            SelectMethods selectMethods = new SelectMethods();
            //selectMethods.BasicQuery();
            //selectMethods.BasicMethod();
            //selectMethods.SelectMethod();
            //selectMethods.SelectQuery();
            selectMethods.AnonymousTypeSelectQuery();
            //selectMethods.AnonymousTypeSelectMethod();
        }

        public static void SelectManyMethods()
        {
            SelectManyMethod selectManyMethod = new SelectManyMethod();
            //selectManyMethod.SelectManyMethods();
            selectManyMethod.SelectManyMethodSyntax();
            //selectManyMethod.SelectManyQuerySyntax();
        }
    }
}
