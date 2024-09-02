using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.ExceptionHandling
{
    public class Numbers
    {
        public void ExceptionExample()
        {
            int number1 = 0;
            int number2 = 0;

            Console.WriteLine("Enter num1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            number2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int output = number1 / number2;
                Console.WriteLine(output);
            }
            catch (Exception)
            {
                Console.WriteLine("Error has happened please contact support");
            }
        }
    }
}
