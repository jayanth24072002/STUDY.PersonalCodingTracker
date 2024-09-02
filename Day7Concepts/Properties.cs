using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.Properties
{
    public class Student
    {
        private int _Id;
        private string _Name;
        private int _PassMark = 35;

        public string Email
        {
            get; set;
        }

        public int PassMark
        {
            get
            {
                return this._PassMark;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty or null");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student cannot be negative");
                }
                this._Id = value;
            }
            get
            {
                return this._Id;
            }
        }
    }
}

