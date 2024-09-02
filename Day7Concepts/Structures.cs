using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.Structures
{
    public struct Customer
    {
        private int id;
        private string name;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Customer (int Id, string Name)
        {
            this.id = Id;
            this.name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}",this.Id,this.Name);
        }
    }
}
