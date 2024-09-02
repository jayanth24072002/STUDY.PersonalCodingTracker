using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class SelectMethods
    {
        List<Employee> employees = new List<Employee>()
        {
             new Employee(){ Id =1,Name = "Tom", Email="Tom@gmail.com"},
             new Employee(){ Id =2,Name = "John", Email="John@gmail.com"},
             new Employee(){ Id =3,Name = "Mark", Email="Mark@gmail.com"},
             new Employee(){ Id =4,Name = "Kim", Email="Kim@gmail.com"},
             new Employee(){ Id =5,Name = "Adam", Email="Adam@gmail.com"},
        };
        public void BasicQuery()
        {
            var basicQuery = (from emp in employees
                              select emp).ToList();

            foreach (var item in basicQuery)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }
            Console.ReadLine();
        }

        public void BasicMethod()
        {
            var basicMethod = employees.ToList();

            foreach (var item in basicMethod)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }
            Console.ReadLine();
        }

        public void SelectQuery()
        {
            var selectQuery = (from emp in employees
                               select new Student()
                               {
                                   StudentId = emp.Id,
                                   FullName = emp.Name,
                                   StEmail = emp.Email,
                               }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Id = {item.StudentId}, Name = {item.FullName}, Email = {item.StEmail}");
            }
            Console.ReadLine();
        }

        public void SelectMethod()
        {
           // List<Student> employees = new List<Student>()
            var selectMethod = employees.Select(emp => new Student()
            {
                StudentId = emp.Id,
                FullName = emp.Name,
                StEmail = emp.Email,
            }).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine($"Id = {item.StudentId}, Name = {item.FullName}, Email = {item.StEmail}");
            }
            Console.ReadLine();
        }

        public void AnonymousTypeSelectQuery()
        {
            var selectQuery = (from emp in employees
                               select new
                               {
                                   CustomId = emp.Id,
                                   CustomName = emp.Name,
                                   CustomEmail = emp.Email,
                               }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }
            Console.ReadLine();
        }

        public void AnonymousTypeSelectMethod()
        {
            var selectMethod = employees.Select(emp => new
            {
                CustomId = emp.Id,
                CustomName = emp.Name,
                CustomEmail = emp.Email,
            }).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }
            Console.ReadLine();
        }
    }

}
