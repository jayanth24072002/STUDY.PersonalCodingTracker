using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class LinqQueryMethods
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void QuerySyntax()
        {
            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void MethodSyntax()
        {
            var methodSyntax = list.Where(obj => obj > 2);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void MixedSyntax()
        {
            var mixedSyntax = (from obj in list
                                select obj).Max();

            Console.WriteLine("max value = " + mixedSyntax);
            Console.ReadLine();
        }
    }

}
