using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class AnyOperator
    {
        public void BasicAnyMethod()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            var isAvailable = numbers.Any();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }

        public void ComplexAnyOperator()
        {
            Student[] students = {
            new Student {
                Name = "kim",Marks=90,
                Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=75 },
                    new Subject() { SubjectName = "English", SubjectMarks=75 },
                    new Subject() { SubjectName = "Art", SubjectMarks=75 },
                    new Subject() { SubjectName = "History", SubjectMarks=75 }
                } },

             new Student {
                Name = "kim",Marks=90,
                Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=75 },
                    new Subject() { SubjectName = "English", SubjectMarks=85 },
                    new Subject() { SubjectName = "Art", SubjectMarks=60 },
                    new Subject() { SubjectName = "history", SubjectMarks=90 }
                } },

              new Student {
                Name = "John",Marks=90,
                Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=65 },
                    new Subject() { SubjectName = "English", SubjectMarks=70 },
                    new Subject() { SubjectName = "Art", SubjectMarks=75 },
                    new Subject() { SubjectName = "History", SubjectMarks=95 }
                } },

               new Student {
                Name = "Lee",Marks=90,
                Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=85 },
                    new Subject() { SubjectName = "English", SubjectMarks=75 },
                    new Subject() { SubjectName = "Art", SubjectMarks=80 },
                    new Subject() { SubjectName = "History", SubjectMarks=65 }
                } },

            };

            var student = students.Where(std => std.Subject.Any(x => x.SubjectMarks > 91)).Select(std => std).ToList();
            
            var Query = (from std in students
                         where std.Subject.Any(x => x.SubjectMarks > 91)
                         select std.Name).ToList();

            Console.ReadLine();
        }
    }
}
