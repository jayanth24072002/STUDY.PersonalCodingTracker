using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17Concepts
{
    public class ExtensionMethods
    {
        public void ExtentionString()
        {
            string strName = "pragim";

            string result = strName.ChangeFirstLetterCase();

            Console.WriteLine(result);
        }

        public void ExtentionInt()
        {
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n=> n%2 == 0);

            foreach (int evenNumber in EvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }

        }

    }
}
