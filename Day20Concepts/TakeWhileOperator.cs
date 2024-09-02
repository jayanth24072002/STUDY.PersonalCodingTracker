using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class TakeWhileOperator
    {
        public void TakeWhileMethod()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var MixedSyntax = (from number in numbers select number).TakeWhile(x => x < 7).ToList();

            var methodSyntax = numbers.TakeWhile(x => x < 7).ToList();
           
            Console.ReadLine();
        }

        public void StringsTakeWhileMethod()
        {
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Ada", "Nithish" };

            var methodSyntax = names.TakeWhile((name, index) => name.Length > index).ToList();

            var mixedSyntax = (from name in names select name).TakeWhile((name, index) => name.Length > index).ToList();
          
            Console.ReadLine();
        }
    }
}
