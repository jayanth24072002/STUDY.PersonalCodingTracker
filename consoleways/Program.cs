using System;

namespace consoleways
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter the last name");
            string lastName = Console.ReadLine();
            

            //concatenation
            Console.WriteLine("Enteredfirst name "+ firstName+" and last name"+lastName);

            //placeHolder syntax

            Console.WriteLine("Enteredfirst name {0} and last name {1}", firstName, lastName);

            //interpolation

            Console.WriteLine($"Enteredfirst name {firstName} and last name{lastName}");
        }
    }
}
