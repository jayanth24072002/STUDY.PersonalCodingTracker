using System;

namespace consolereadline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Please enter user name ");
            string userName = Console.ReadLine();
            Console.WriteLine("provided username " + userName);
           
        }

    }
}
