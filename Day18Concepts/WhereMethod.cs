using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Concepts
{
    public class WhereMethod
    {
        public void WhereQuerySyntax()
        {
            var dataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var querySyntax = (from number in dataSource
                               where number <= 5 || number > 9
                               select number).ToList();

            foreach (var item in querySyntax)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }

        public void WhereMethodSyntax()
        {
            var number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = number.Where(num => num <= 5 || num > 9).ToList();

            foreach (var item in methodSyntax)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }

        public void StringWherequerySyntax()
        {
            var number = new List<string> {"Tom", "Harry", "Adam", "Ponting", "Sachin" };

            var querySyntax = (from str in number
                               where str == "Tom"  || str.Length > 5
                               select str).ToList();

            foreach (var item in querySyntax)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }

        public void StringWhereMethodSyntax()
        {
            var dataSource = new List<string> { "Tom", "Harry", "Adam", "Ponting", "Sachin" };

            var MethodSyntax = dataSource.Where(str => str.Length > 5 || str == "Tom").ToList();

            foreach (var item in MethodSyntax)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }

        public void WhereExample()
        {
            var dataSource = new List<Employee>()
        {
             new Employee(){ Id =1,Name = "Tom", Email="Tom@gmail.com", Programming =
                 new List<Techs>{
                     new Techs() {Technology = "C#" },
                     new Techs() {Technology = "PHP" },
                     new Techs() {Technology = ".Net" },

                 } },
             new Employee(){ Id =2,Name = "John", Email="John@gmail.com", Programming =
                 new List<Techs>{
                     new Techs() {Technology = "C#" },
                     new Techs() {Technology = "PHP" },
                     new Techs() {Technology = ".Net" },

                 } },
             new Employee(){ Id =3,Name = "Mark", Email="Mark@gmail.com", Programming =
                 new List<Techs>{
                     new Techs() {Technology = "C#" },
                     new Techs() {Technology = "Java" },
                     new Techs() {Technology = ".Net" },

                 } },
            
             new Employee(){ Id =4,Name = "Lee", Email="Lee@gmail.com", Programming =new List<Techs>() },
             new Employee(){ Id =5,Name = "Leo", Email="leo@gmail.com", Programming =new List<Techs>() },
        };

            var querySyntax = (from employee in dataSource
                              where employee.Programming.Count == 0
                              select employee).ToList();

            Console.ReadLine();
        }
    }
}
