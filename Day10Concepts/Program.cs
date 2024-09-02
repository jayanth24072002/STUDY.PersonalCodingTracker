using System;
using Day10Concepts.AccessModifiers;
using Day10Concepts.EnumConcepts;
using WhyEnum = Day10Concepts.WhyEnum;

namespace Day10Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AccessModifiers();
            //EnumConcepts();
            EnumExample();
            
        }

        private static void AccessModifiers()
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.ID);
        }

        public static void EnumConcepts()
        {
            short[] values = (short[])Enum.GetValues(typeof(Gender));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            String[] names = Enum.GetNames(typeof(Gender));

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void EnumExample()
        {
            WhyEnum.Customer[] customers = new WhyEnum.Customer[3];

            customers[0] = new WhyEnum.Customer
            {
                Name = "Mark",
                Gender = 1
            };

            customers[1] = new WhyEnum.Customer
            {
                Name = "Sam",
                Gender = 2
            };

            customers[2] = new WhyEnum.Customer
            {
                Name = " Mary",
                Gender = 0
            };


            foreach (WhyEnum.Customer customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender ={1}", customer.Name, GetGender(customer.Gender));
            }
        }

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 3:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
    }
}
