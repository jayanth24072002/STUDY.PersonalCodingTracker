using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.GenericQueue
{
    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class MovieTicketBookingSystem
    {
        Queue<Customer> queue;
        public MovieTicketBookingSystem()
        {
            queue = new Queue<Customer>();
        }

        public void AddToQueue(Customer customer)
        {
            queue.Enqueue(customer);
            //Thread.Sleep(1000);
            Console.WriteLine($"Added to queue: {customer.Name}");
        }

        public void ProcessBooking()
        {
            if(queue.Any())
            {
                var customer = queue.Dequeue();
                //Thread.Sleep(1000);
                Console.WriteLine($"Proceesed booking for : {customer.Name}");
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\n\tCurrent queue");
            Console.WriteLine("\t--------");

            foreach(var customer in queue)
            {
                Console.WriteLine("\t" + customer.Name);
            }
        }
    }
}
