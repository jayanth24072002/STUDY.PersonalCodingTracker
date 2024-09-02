using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class SkipWhile
    {
        public void IntegerUsingSkipWhile()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var methodSyntax = numbers.SkipWhile(number => number < 6).ToArray();

            var mixedSyntax = (from number in numbers  select number).SkipWhile(x => x < 5).ToArray();
           
            Console.ReadLine();
        }

        public void StringUsingSkipWhile()
        {
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Ada", "Nithish" };

            var mixedSyntax = names.SkipWhile((value, index) => value.Length < index).ToList();

            Console.ReadLine();
        }
    }
}
