using System;
using Employee = Day5Concepts.EmployeeManagement;
using Student = Day5Concepts.StudentManagement;
using Day5Concepts.ClassIntroduction;
using Day5Concepts.StaticAndInstance;

namespace Day5Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement();
            //ClassIntroduction();
            //StaticAndInstance();
        }

        static void EmployeeManagement()
        {
            Employee.Department employeeDepartment = new Employee.Department();
            employeeDepartment.DisplayDepartmentInfo();

            Student.Department studentDepartment = new Student.Department();
            studentDepartment.DisplayDepartmentInfo();
        }

        static void ClassIntroduction()
        {
            Customer customer = new Customer("savar", "Technologies");
            customer.PrintFullName();
        }

        static void StaticAndInstance()
        {
            Circle circle1 = new Circle(4);
            float area1 = circle1.CalculatedArea();
            Console.WriteLine("Area = {0}",area1);

            Circle circle2 = new Circle(5);
            float area2 = circle2.CalculatedArea();
            Console.WriteLine("Area = {0}", area2);
        }
    }
}
