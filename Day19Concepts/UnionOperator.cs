using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class UnionOperator
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

        public void BasicStringUnionOperator()
        {
            List<string> strings1 = new List<string>() { "A", "B", "C", "D" };
            List<string> strings2 = new List<string>() { "C", "D", "E", "F" };

            var methodSyntax = strings1.Union(strings2).ToList();

            Console.ReadLine();
        }

        public void ComplexUnionOperatorusingAnynamuous()
        {
            var ms = students1.Union(students2 , new StudentComparer()).ToList();
            var methodSyntax = students1.Select(x => new {x.Id, x.Name}).Union(students2.Select(x => new {x.Id, x.Name})).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine($" Id - {student.Id},Name -{student.Name}");
            }
            Console.ReadLine();
        }

        public void ComplexUnionOperatorsUsingComparer()
        {
            var methodSyntax = students1.Union(students2, new StudentComparer()).ToList();

            foreach (var student in methodSyntax)
            {
                Console.WriteLine($" Id - {student.Id},Name -{student.Name}");
            }
            Console.ReadLine();
        }
    }
}
