using System;
using System.Runtime.InteropServices;
using Day9Concepts.OptionalParameter;
using Day9Concepts.OverrideToString;
using Day9Concepts.ConvertToString;
using Day9Concepts.StringAndStringBuilder;
using System.Text;

namespace Day9Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ParameterArray();
            //MethodOverloading();
            //ParameterDefault();
            //OptionalAttribute();
            //Override();
            //ConvertTostring();
            StringAndStringBuilder();
        }

        public static void ParameterArray()
        {
            ParameterExample.AddNumbers(10, 20, 30);
        }

        public static void MethodOverloading()
        {
            MethodOverloadingExample.AddNumbers(10, 30);
        }

        public static void ParameterDefault()
        {
            ParameterDefaultExample.AddNumbers(10, 30,new int[] {30,40});
        }

        public static void OptionalAttribute()
        {
            OptionalAttributeExample.AddNumbers(10, 30, new int[] { 30, 40, 50 });
        }

        private static void Override()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            OverrideTostring overrideToString = new OverrideTostring();
            overrideToString.FirstName = "Simon";
            overrideToString.LastName = "Tan";

            Console.WriteLine(Convert.ToString(overrideToString));
        }

        private static void ConvertTostring()
        {
            Customer customer = new Customer();
            string str = Convert.ToString(customer);
            Console.WriteLine(str);
        }

        public static void StringAndStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine(stringBuilder.ToString());

        }
    }
}
