using System;

namespace Day1Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
             WriteLine();
            // ReadLine();
            // WaysToWriteConsole();
            // Variable();
            // BulitinDataTypes();
        }

        static void WriteLine()
        {
            // int number = 12345;
            // string name = "Savar Technologies";
            Console.Write("Savar");
            Console.WriteLine("Technologies");
            Console.WriteLine("-------");
        }

        static void ReadLine()
        {
            Console.Write("Please enter user name ");
            string userName = Console.ReadLine();
            Console.WriteLine("provided username " + userName);
        }

        static void WaysToWriteConsole()
        {
            Console.WriteLine("please enter the first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("please enter the last name");
            string lastName = Console.ReadLine();

            //concatenation
            Console.WriteLine("Enteredfirst name " + firstName + " and last name " + lastName);

            //placeHolder syntax
            Console.WriteLine("Enteredfirst name {0} and last name {1}", firstName, lastName);

            //interpolation
            Console.WriteLine($"Enteredfirst name {firstName} and last name {lastName}");
        }

        static void Variable()
        {
            int userNumber = 1234; //local
            Console.WriteLine(userNumber);

            string userName = "savar";
            Console.WriteLine(userName);
        }

        static void BulitinDataTypes()
        {
            Console.WriteLine($"size of float{sizeof(float)}");
            Console.WriteLine($"max value is{int.MaxValue}");
            Console.WriteLine($"min value {int.MinValue}\n");

            Console.WriteLine($"size of double {sizeof(double)}");
            Console.WriteLine($"max value is{double.MaxValue}");
            Console.WriteLine($"min value {double.MinValue}\n");

            Console.WriteLine($"size of decimal{sizeof(decimal)}");
            Console.WriteLine($"max value is{decimal.MaxValue}");
            Console.WriteLine($"min value {decimal.MinValue}");
        }
    }
}
