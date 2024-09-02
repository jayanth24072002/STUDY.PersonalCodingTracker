using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class IntersectOperator
    {
        List<Student> students1 = new List<Student>()
            {
                new Student() {  Id =1, Name ="John"},
                new Student() { Id = 2, Name = "Kim" },
                new Student() { Id = 3, Name = "John" },
                new Student() { Id = 4, Name = "Mark" },
            };

        List<Student> students2 = new List<Student>()
            {
                new Student() {  Id =1, Name ="John"},
                new Student() { Id = 2, Name = "Kim" },
                new Student() { Id = 5, Name = "John" },
                new Student() { Id = 6, Name = "Mark" },
            };
        public void IntersectMethod()
        {
            List<string> strings1 = new List<string>() { "A","B","C","D"};
            List<string> strings2 = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = strings1.Intersect(strings2).ToList();

            Console.ReadLine();
        }

        public void ComplexIntersectMethodUsingAnonymous()
        {
            var methodSyntax = students1.Select(x => new { x.Id, x.Name }).Intersect(students2.Select(x => new { x.Id, x.Name})).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine($" Id - {student.Id},Name -{student.Name}");
            }

            Console.ReadLine();
        }

        public void ComplexIntersectMethodUsingComparer()
        {
            var methodSyntax = students1.Intersect(students2, new StudentComparer()).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine($" Id - {student.Id},Name -{student.Name}");
            }

            Console.ReadLine();
        }
    }
}
