using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class OperatorAllMethod
    {
        public void BasicAllQuery()
        {
            Student[] student = {new Student {Name = "kim",Marks =90 },
                   new Student {Name = "John",Marks =80},
                   new Student {Name = "Lee", Marks=75}};

            var query = student.All(student => student.Marks > 70);

            Console.ReadLine();
        }

        public void ComplexAllMethod()
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

            }; ;
            var student = students.Where(std => std.Subject.All(x => x.SubjectMarks > 70)).Select(std => std).ToList();

            var query = (from std in students
                         where std.Subject.All(x => x.SubjectMarks > 70)
                         select std).ToList(); 
        }

    }
}
