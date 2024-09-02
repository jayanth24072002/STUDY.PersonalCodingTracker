using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Concepts
{
    public class OrderByMethod
    {
        public void OrderByAescendingQuerySyntax()
        {
            var number = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var querySyntax = (from num in number
                               where num > 10
                               orderby num
                               select num).ToList();    

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void OrderByAescendingMethodSyntax()
        {
                var number = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

                var methodSyntax = number.Where(num => num > 10).OrderBy(num => num).ToList();

                foreach (var item in methodSyntax)
                {
                    Console.WriteLine(item);
                }

                Console.ReadLine();
        }

        public void StringOrderByQuerySyntax()
        {
            var dataSourcestring = new List<string>() { 
            "smith",
            "ander",
            "wright",
            "mitchell",
            "strack",
            "allen"};

            var querySyntax = (from name in dataSourcestring
                               where name.Length > 6
                               orderby name
                               select name).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void StringOrderByMethodSyntax()
        {
            var dataSourcestring = new List<string>() {
            "smith",
            "ander",
            "wright",
            "mitchell",
            "strack",
            "allen"};

            var methodSyntax = dataSourcestring.Where(name => name.Length > 6).OrderBy(name => name).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void AscendingOrder()
        {
            var dataSource = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Mark",
                    Email = "mark@gamil"
                },

                new Employee()
                {
                    Id = 2,
                    Name = "John",
                    Email = "jofn@gmail"
                },

                new Employee()
                {
                    Id = 3,
                    Name = "Pam",
                    Email = "Pam@gamil.com"
                },

                new Employee()
                {
                    Id = 4,
                    Name = "sam",
                    Email = "sam@gamil.com"
                },
            };

            var querySyntax = (from emp in dataSource
                               orderby emp.Name
                               select emp).ToList();

            var methodSyntax = dataSource.Where(emp => emp.Id >2).OrderBy(emp => emp.Name).ToList();

            Console.ReadLine()


    }
}
