using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Concepts
{
    public class DistinctOperator
    {
        public void BasicDistinctOperator()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 3,5,5,5 };

            var mixedSyntax = numbers.Distinct().ToList();

            var querySyntax = (from number in numbers
                               select number).ToList();

            Console.ReadLine();
        }
        public void DistinctMethod()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id =1, Name = "John" },
                new Student() {Id =2, Name = "Kim" },
                new Student() {Id =3, Name = "John" },
                new Student() {Id =4, Name = "Mark" },
            };

            var methodSyntax = students.Distinct().ToList();

            Console.ReadLine();
        }

    }
}
