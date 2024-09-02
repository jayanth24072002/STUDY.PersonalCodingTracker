using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class SingleAndSingleOrDefault
    {
        public void SingleVsSingleOrDefault()
        {
            List<int> numbers = new List<int>() {1, 2, 3 };

            var methodSyntax = numbers.Where(x => x > 5).Single();

            Console.ReadLine();
        }
    }
}
