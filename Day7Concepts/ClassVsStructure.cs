﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.ClassVsStructure
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ~Customer()
        {
        }
    }
}
