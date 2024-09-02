using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class ContainsOperator
    {
        public void BasicList()
        {
            List<string> students = new List<string>() { "kim", "Jacob", "John", "Simon" };

            var isExist = students.AsEnumerable().Contains("Nitish");

            var isExistUsingQuery = (from student in students
                                     select student).Contains("Simon");

            Console.WriteLine(isExistUsingQuery);
        }

        public void ComplexContainsOperatorMethodSyntax()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id = 1, Name ="Kim"},
                new Student(){Id = 2, Name ="John"},
            };
            var comparer = new StudentComparer();

            var isExist = students.Contains(new Student() { Id = 1, Name = "Kim" }, comparer);
        }

        public void ComplexContainsOperatorQuerySyntax()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id = 1, Name ="Kim"},
                new Student(){Id = 2, Name ="John"},
            };
            var comparer = new StudentComparer();

            var qs = (from std in students
                      select std).Contains(new Student() { Id = 1, Name = "Kim" }, comparer);

        }
    }
}
