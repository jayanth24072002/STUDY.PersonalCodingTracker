using System;

namespace Day4Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhileLoop();
            //DoWhile();
            //CoffeePurchaseExample();
            //ForLoop();
            //ForEachLoop();
            //Program p = new Program();
            //p.EvenNumber();
            //Method();
        }

        static void WhileLoop()
        {
            Console.WriteLine("Please enter the number");
            int UserNumber = int.Parse(Console.ReadLine());
            int Start = 1;

            while (Start <= UserNumber)
            {
                Console.Write(Start + " ");
                Start = Start + 2;
            }
        }

        static void DoWhile()
        {
            string UserChoice = " ";

            do
            {
                Console.WriteLine("Please enter the number");
                int UserNumber = int.Parse(Console.ReadLine());
                int Start = 1;

                while (Start <= UserNumber)
                {
                    Console.Write(Start + " ");
                    Start = Start + 2;
                }

                do
                {
                    Console.WriteLine("Do you want to continue please enter yes or No");
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("please enter the correct choice");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }

        static void CoffeePurchaseExample()
        {
            int TotalAmount = 0;
            string UserDecision = " ";

            do
            {
                int userchoice = -1;

                do
                {
                    Console.WriteLine("Please select your cofee 1 - small, 2 - Medium ,3 - Large");
                    userchoice = int.Parse(Console.ReadLine());

                    switch (userchoice)
                    {
                        case 1:
                            TotalAmount += 10;
                            break;
                        case 2:
                            TotalAmount += 20;
                            break;
                        case 3:
                            TotalAmount += 30;
                            break;
                        default:
                            Console.WriteLine($"Entered choice is invalid {userchoice}");
                            break;
                    }
                } while (userchoice != 1 && userchoice != 2 && userchoice != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No");
                    UserDecision = Console.ReadLine().ToUpper();

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine("Please enter the correct Decision");
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            } while (UserDecision == "YES");

            Console.WriteLine("Thank you shopping please come again");
            Console.WriteLine($"Total Bill Amount = {TotalAmount}");
        }

        static void ForLoop()
        {
            for (int i = 0; i < 30; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        static void ForEachLoop()
        {
            int[] Numbers = new int[3];

            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }

        public void EvenNumber()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public static void Method()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine($"sum = {Total} && product = {Product}");
        }

        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
    }
}
