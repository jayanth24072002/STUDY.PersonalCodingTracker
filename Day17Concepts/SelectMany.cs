using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class SelectManyMethod
    {
        List<Employee> dataSources = new List<Employee>()
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
             new Employee(){ Id =4,Name = "Jay", Email="Jay@gmail.com", Programming =
                 new List<Techs>{
                     new Techs() {Technology = "C#" },
                     new Techs() {Technology = "PH" },
                     new Techs() {Technology = ".Net" },

                 } },
             new Employee(){ Id =5,Name = "Lee", Email="Lee@gmail.com", Programming =new List<Techs>() },
             new Employee(){ Id =6,Name = "Leo", Email="leo@gmail.com", Programming =new List<Techs>() },


        };
        public void SelectManyMethods()
        {
            List<string> strList = new List<string>() { "Nithish", " kowshik" };

            var methodResult = strList.SelectMany(x => x).ToList();

            foreach (var item in methodResult)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }

        public void SelectManyMethodSyntax()
        {
            var methodSyntax = dataSources.SelectMany(emp => emp.Programming).ToList();

            foreach ( var item in methodSyntax)
            {
                Console.WriteLine($"Programming - {item}");
            }
        }

        public void SelectManyQuerySyntax()
        {
            var querySyntax = (from emp in dataSources
                                from skill in emp.Programming
                                select skill).ToList();

            foreach (var item in querySyntax)
            {
                Console.Write("Programming - " + item);
            }
        }
    }
}
