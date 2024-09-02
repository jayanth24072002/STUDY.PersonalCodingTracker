using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Concepts
{
    public class ReverseMethod
    {
        public void BasicReverseMethod()
        {
            int[] rollNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var mq = rollNums.Reverse();

            var qs = (from number in rollNums
                      select number).Reverse();

            foreach (var item in qs)
            {
                Console.WriteLine(item);
            }
        }

        public void StringReverseMethod()
        {
            List<string> names = new List<string>() { "Mark", "John", "Adam", "Umar", "Bob" };


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========");

            var reversed = names.AsEnumerable().Reverse();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
