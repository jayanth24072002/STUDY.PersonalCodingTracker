using System;

namespace variables
{

    internal class Program
    {
       static int userNumber = 124;//global
        static void Main(string[] args)
        {
           // int userNumber = 1234; //local
            Console.WriteLine(userNumber);

            string userName = "savar";
            Console.WriteLine(userName);
            

        }
        static void TestMethod()
        {
            Console.WriteLine(userNumber);
            Console.WriteLine(username);
        }

    }
}
