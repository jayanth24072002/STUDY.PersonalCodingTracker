using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Concepts
{
    public class OrderByDesending
    {
        public void OrderByDesendingQuerySyntax()
        {
            var numbers = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var querySyntax = (from number in numbers
                               where number > 10
                               orderby number
                               select number).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void OrderByDesendingMethodSyntax()
        {
            var numbers = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var methodSyntax = numbers.Where(num => num > 10).OrderBy(num => num).ToList();

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

            var querySyntax =  from name in dataSourcestring
                               orderby name descending
                               select name;

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

            var methodSyntax = dataSourcestring.OrderByDescending(name => name).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void ComplexDesendingOrder()
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
                               orderby emp.Id descending
                               select emp).ToList();

            var methodSyntax = dataSource.OrderByDescending(emp => emp.Id ).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"{item.Id}, name ={item.Name}, Email = {item.Email}");
            }

            Console.ReadLine();
        }
    }
}

