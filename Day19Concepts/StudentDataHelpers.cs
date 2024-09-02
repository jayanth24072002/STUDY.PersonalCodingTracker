﻿using Day19Concepts;
using System.Collections.Generic;

internal static class StudentDataHelpers
{
    public static List<Student> GetStudents()
    {
        Student[] students = {
                new Student {
                    Name = "kim", Marks = 90,
                    Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=75 },
                    new Subject() { SubjectName = "English", SubjectMarks=75 },
                    new Subject() { SubjectName = "Art", SubjectMarks=75 },
                    new Subject() { SubjectName = "History", SubjectMarks=75 }
                } },

             new Student {
                 Name = "kim", Marks = 90,
                 Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=75 },
                    new Subject() { SubjectName = "English", SubjectMarks=85 },
                    new Subject() { SubjectName = "Art", SubjectMarks=60 },
                    new Subject() { SubjectName = "history", SubjectMarks=90 }
                } },

              new Student {
                  Name = "John", Marks = 90,
                  Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=65 },
                    new Subject() { SubjectName = "English", SubjectMarks=70 },
                    new Subject() { SubjectName = "Art", SubjectMarks=75 },
                    new Subject() { SubjectName = "History", SubjectMarks=95 }
                } },

               new Student {
                   Name = "Lee", Marks = 90,
                   Subject = new List<Subject>()
                {
                    new Subject() { SubjectName = "math", SubjectMarks=85 },
                    new Subject() { SubjectName = "English", SubjectMarks=75 },
                    new Subject() { SubjectName = "Art", SubjectMarks=80 },
                    new Subject() { SubjectName = "History", SubjectMarks=65 }
                } },

            };
    }
}