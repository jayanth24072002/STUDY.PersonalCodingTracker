using System;
using System.Threading;

namespace Day3Concepts
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ConditionalOperator();
            //WithoutTernaryOperator();
            //TernaryOperator();
            //IfStatement();
            //SwitchStatement();
            CoffeePurchaseExample();
        }

        static void ConditionalOperator()
        {
            int number1 = 12;
            int number2 = 13;

            if (number1 == 12 || number2 == 13)
            {
                Console.WriteLine("HelloWorld");
            }
        }

        static void WithoutTernaryOperator()
        {
            int number = 17;
            bool isNumber10;

            if (number == 10)
            {
                isNumber10 = true;
            }
            else
            {
                isNumber10 = false;
            }
            Console.WriteLine("number==10 is {0}", isNumber10);
        }

        static void TernaryOperator()
        {
            int Number = 10;
            bool IsNumber10 = Number == 10 ? true : false;

            Console.WriteLine("number==10 is {0}", IsNumber10);
        }

        static void IfStatement()
        {
            Console.WriteLine("Please enter the number ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                Console.WriteLine("The number is 0");
            }
            else if (userNumber == 1)
            {
                Console.WriteLine("The number is 1");
            }
            else
            {
                Console.WriteLine("Please check the input");
            }
        }

        static void SwitchStatement()
        {
            Console.WriteLine("Please enter the number ");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 2:
                case 3:
                case 10:
                    Console.WriteLine($"Your number is {userNumber}");
                    break;
                default:
                    Console.WriteLine("your number is not 2 3 10");
                    break;
            }

        }

        static void CoffeePurchaseExample()
        {
            int totalAmount = 0;
            Start:
            Console.WriteLine("Please select your cofee 1 - small, 2 - Medium ,3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalAmount += 10;
                    break;
                case 2:
                    totalAmount += 20;
                    break;
                case 3:
                    totalAmount += 30;
                    break;
                default:
                    Console.WriteLine($"Entered choice is invalid {userChoice}");
                    goto Start;
            }

            Console.WriteLine("Do you want to buy another coffee - Yes or No");
            string UserDecision = Console.ReadLine();

            Decision:
            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine($"your choice {UserDecision} is invalid. Please try again ");
                    goto Decision;
            }
            Console.WriteLine("Thank you shopping please come again");
            Console.WriteLine($"Total Bill Amount = {totalAmount}");
        }
    }
}

