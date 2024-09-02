using System;
using NeedForProperties = Day7Concepts.NeedForProperties;
using Properties = Day7Concepts.Properties;
using Structure = Day7Concepts.Structures;
using ClassVsStructure = Day7Concepts.ClassVsStructure;

namespace Day7Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NeedForProperties();
            //Properties();
            //Structures();
            ClassVsStructure();
        }

        public static void NeedForProperties()
        {
            NeedForProperties.Student student = new NeedForProperties.Student();
            student.SetId(101);
            student.SetName("Mark");

            Console.WriteLine("Student ID = {0} ", student.GetId());
            Console.WriteLine("Student Name = {0} ", student.GetName());
            Console.WriteLine("Student PassMark = {0} ", student.GetPassMark());
        }

        public static void Properties()
        {
            Properties.Student student = new Properties.Student();
            student.Id= 101;
            student.Name = "Mark";
            student.Email = "mark1@gmail.com";

            Console.WriteLine($"Student ID = {student.Id}");
            Console.WriteLine($"Student Name = {student.Name} ");
            Console.WriteLine($"PassMark = {student.PassMark} ");
            Console.WriteLine($"Email = {student.Email} ");
        }

        public static void Structures()
        {
            Structure.Customer customer1 = new Structure.Customer(101,"john");
            customer1.PrintDetails();

            Structure.Customer customer2 = new Structure.Customer();
            customer2.Id = 102;
            customer2.Name = "Jay";
            customer2.PrintDetails();

            Structure.Customer customer3 = new Structure.Customer
            {
                Id = 103,
                Name = "Rod"
            };
            customer3.PrintDetails();
        }

        public static void ClassVsStructure()
        {
            int i = 0;
            int j = 1;
            i = i + j;

            Console.WriteLine("i = {0} && j = {1}", i, j);

            ClassVsStructure.Customer customer1 = new ClassVsStructure.Customer();
            customer1.Id = 101;
            customer1.Name = "mark";

            ClassVsStructure.Customer customer2 = customer1;
            customer2.Name = "Mary";

            Console.WriteLine("C1.Name = {0} && C2.Name = {1}",customer1.Name, customer2.Name);
        }
    }
}
