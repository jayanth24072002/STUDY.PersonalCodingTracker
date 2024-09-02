using Inhertance = Day6Concepts.Inhertance;
using Polymorphism = Day6Concepts.Polymorphism;
using Day6Concepts.ParentClass;
using MethodOverriding = Day6Concepts.MethodOverriding;
using MethodHidding = Day6Concepts.MethodHidding;
using System;
using System.ComponentModel;

namespace Day6Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inhertance();
            //ParentClass();
            //Polymorphism();
            //MethodOverriding();
            //MethodHidding();
        }

        static void Inhertance()
        {
            Inhertance.FullTimeEmployee fte = new Inhertance.FullTimeEmployee();
            fte.FirstName = "Test";
            fte.LastName = "Tech";
            fte.YearlySalary = 1000000;
            fte.PrintFullName();

            Inhertance.PartTimeEmployee pte = new Inhertance.PartTimeEmployee();
            pte.FirstName = "Savar";
            pte.LastName = "Tech";
            pte.HourlyRate = 1000;
            pte.PrintFullName();
        }

        static void ParentClass()
        {
            ChildClass childClass = new ChildClass();
        }

        static void Polymorphism()
        {
            Polymorphism.Employee[] employees = new Polymorphism.Employee[4];

            employees[0] = new Polymorphism.Employee();
            employees[1] = new Polymorphism.PartTimeEmployee();
            employees[2] = new Polymorphism.FullTimeEmployee();
            employees[3] = new Polymorphism.TemporaryEmployee();

            foreach (Polymorphism.Employee e  in employees)
            {
                e.PrintFullName();
            }
        }

        static void MethodOverriding()
        {
            MethodOverriding.BaseClass baseClass = new MethodOverriding.DerivedClass();
            baseClass.Print();
        }

        static void MethodHidding()
        {
            MethodHidding.BaseClass baseClass = new MethodHidding.DerivedClass();
            baseClass.Print();
        }
    }
}
