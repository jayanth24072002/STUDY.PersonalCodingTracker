using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class ExceptOperator
    {
        List<Student> students = new List<Student>()
            {
                new Student() {  Id =1, Name ="John"},
                new Student() { Id = 2, Name = "Kim" },
                new Student() { Id = 3, Name = "John" },
                new Student() { Id = 4, Name = "Mark" },
            };

        List<Student> students1 = new List<Student>()
            {
                new Student() {  Id =1, Name ="John"},
                new Student() { Id = 2, Name = "Kim" },
                new Student() { Id = 5, Name = "John" },
                new Student() { Id = 6, Name = "Mark" },
            };
        public void ExceptMethod()
        {
            var ms = students.Select(x=> new { x.Id, x.Name }).Except(students1.Select(x => new { x.Id, x.Name })).ToList();

            Console.ReadLine();
        }

        public void ExceptMethodUsingComparer()
        {
            var ms = students.Except(students1,new StudentComparer() ).ToList();

            var qs = (from std in students
                      select std).Except(students1,new StudentComparer() ).ToList();
            Console.ReadLine();
        }
    }
}
