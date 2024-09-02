using Day12Concepts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day12Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListCollection();
            //ListClassFunction();
            //ListClassRanges();
            //ListOfSimpleType();
            //Delegate();
        }

        public static void ListCollection()
        {
            ListCollectionClass C1 = new ListCollectionClass();
            C1.ListCollection();
            C1.ListCollectionUsingFor();
            C1.Insert();
        }

        public static void ListClassFunction()
        {
            ListClassFunctions C2 = new ListClassFunctions();
            C2.Find();
            C2.FindLast();
            C2.FindAll();
            C2.Dictionary();
            C2.FindIndex();
            C2.Exists();
        }

        public static void ListOfSimpleType()
        {
            ListOfSimpleTypes C3 = new ListOfSimpleTypes();
            C3.NumberSort();
            C3.AlphabetSort();
        }

        public static void ListClassRanges()
        {
            ListClassRanges C4 = new ListClassRanges();
            C4.AddRange();
            C4.GetRange();
            C4.InsertRange();
            C4.RemoveRanges();
            C4.RemoveAt();
        }

        public static void Delegate()
        {
            Delegates C5 = new Delegates();
            C5.DelegateWithList();
        }
    }
}
