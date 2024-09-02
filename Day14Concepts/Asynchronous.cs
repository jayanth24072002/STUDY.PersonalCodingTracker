using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.Asynchronous
{
    public class AsynchronousExample
    {
        public async void Fun1()
        {
            for (int i = 0; i < 100000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Fun 1 :- " + i);
            }
        }

        public async void Fun2()
        {
            for (int i = 0; i < 100000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("Fun 2 :- " + i);
            }
        }
    }
}
