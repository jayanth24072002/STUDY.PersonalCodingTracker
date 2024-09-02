using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Concepts
{
    internal class OfTypeMethod
    {
        public void OfTypeQuerySyntax()
        {
            var dataSource = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5 };

            var querySyntax = (from x in dataSource
                              where x is string
                              select x).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public void OfTypeMethodSyntax()
        {
            var number = new List<object>() { "Adam", "Harry", "Kim", "John", 1, 2, 3, 4, 5 };

            var methodSyntax = number.OfType<string>().Where(x => x.Length > 3).ToList();

            foreach(var item in methodSyntax )
            {
                Console.WriteLine(item);
            }
        }
    }
}
