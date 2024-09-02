using Microsoft.VisualBasic;
using System;

namespace Day2Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ImplicitConversion();
            // ExplicitConversion();
            // ExplicitConvertclass();
            // BoxingUnboxing();
            // Parse();
            // TryParse();
            // NullableType();
            // IntegerArray();
             //StringArray();
             //TestMethod();
        }

        static void ImplicitConversion()
        {
            int n1 = 10;
            Console.WriteLine(n1);

            float n2 = n1;
            Console.WriteLine(n2);

            long n3 = n1;
            Console.WriteLine(n3);
        }

        static void ExplicitConversion()
        {
            float f1 = 7.93f;
            Console.WriteLine(f1);

            int i1 = (int)f1;
            long l1 = (long)f1;

            Console.WriteLine("After the conversion");
            Console.WriteLine(i1);
            Console.WriteLine(l1);

            int i2 = Convert.ToInt32(f1);  //using convertclass
            Console.WriteLine(i2);

            float f2 = 2372456728109.23F;
            int n1 = (int)f2;
            int n2 =Convert.ToInt32(f2);
        }

        static void BoxingUnboxing()
        {
            int i = 100; //value
            object obj = i;//reference
            Console.WriteLine("boxing");
            Console.WriteLine(i);
            Console.WriteLine(obj);
            
            object obj2 = i;//reference
            int i2 = 100; //value

            Console.WriteLine("unboxing");
            Console.WriteLine(obj2);
            Console.WriteLine(i2);
        }

        static void Parse()
        {
            string strNumber = "1234";
            Console.WriteLine(strNumber);   
            int num = int.Parse(strNumber);
            Console.WriteLine(num);
        }

        static void TryParse()
        {
            Console.WriteLine("please enter the first number");
            int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine("please enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"sum of these numbers {num + num2}");
        }

        static void NullableType()
        {
            string num = null;
            Console.WriteLine(num);

            int? num2 = null;
            Console.WriteLine(num2);

            bool? nullable = null;
            Console.WriteLine(nullable);
        }

        static void IntegerArray()
        {
            //Decalaration of integer array
            int[] employeeIds = new int[5];
            employeeIds[0] = 25;
            employeeIds[1] = 40;
            employeeIds[2] = 65; 
            employeeIds[3] = 98;
            employeeIds[4] = 100;

            //initilization of integer array
            int[] employeeIds1 = new int[5] { 25, 40, 65, 98, 100 };
            int[] employeeIds2 = new int[] { 25, 40, 65, 98, 100 };
            int[] employeeIds3 = { 25, 40, 65, 98, 100 };
            Console.WriteLine(employeeIds1);
        }

        static void StringArray()
        {
            //Decalaration of string array
            string[] employeeName = new string[3];

            //initilization of string Array
            employeeName[0] = "Jayanth";
            employeeName[1] = "Rohit";
            employeeName[2] = "Sarat";
        }

        ///<summary>
        ///This is TestMethod 
        /// </summary>
        static void TestMethod()
        {
            //Console.WriteLine("Test1");
           /* Console.WriteLine("Test2");
            Console.WriteLine("Test3");*/
        }
    }
}
