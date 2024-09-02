using System;

namespace Day5Concepts.ClassIntroduction
{
    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name ={0}", this._firstName + " " + this._lastName);
        }
    }
}
