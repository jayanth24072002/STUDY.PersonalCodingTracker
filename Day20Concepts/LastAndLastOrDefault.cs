using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class LastAndLastOrDefault
    {
        public void LastVsLastOrDefault()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.Where(x=> x > 15).LastOrDefault();

            var mixedSyntax = (from n in numbers
                               where n > 15
                               select n).Last();

            Console.ReadLine();
        }
    }
}
