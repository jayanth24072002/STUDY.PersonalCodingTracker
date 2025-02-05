﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public int Id { get; set; }

        public List<Subject> Subject {  get; set; }
    }

    public class Subject 
    {
        public string SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }
            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(Student obj)
        {
            if (Object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();
            
            return idHashCode ^ nameHashCode;
        }
    }
}
