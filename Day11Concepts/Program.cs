using System;
using Day11Concepts.Generics;

namespace Day11Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics();
            ArrayConcepts();
            ArrayCompare();
        }

        public static void ArrayConcepts()
        {

            string[] arrPlanets = new string[2];
            arrPlanets[0] = "Mercury";
            arrPlanets[1] = "Venus";

            foreach (var item in arrPlanets)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static void ArrayCompare()
        {
            string[] daysOfWeek_arr1 =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            string[] daysOfWeek_arr2 =
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            bool isEqual = daysOfWeek_arr1 == daysOfWeek_arr2;

            Console.WriteLine($"is daysOfWeek_arr1 == daysOfWeek_arr2: {isEqual}");

            Console.ReadKey();
        }
    
    public static void Generics()
        {
            bool Equal = Calculator<string>.AreEqual("A", "A");

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

