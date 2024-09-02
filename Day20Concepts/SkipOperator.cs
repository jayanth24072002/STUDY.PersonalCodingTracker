using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class SkipOperator
    {
        public void SkipOperatorExample()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Where(x => x > 4).Skip(3).ToArray();

            List<string> names = new List<string>() { "Kim", "John", "Mark", "Ada", "Nithish" };

            var mixedSyntax = (from name in names select name).Skip(2).ToList();

            Console.ReadLine();
        }
    }
}
