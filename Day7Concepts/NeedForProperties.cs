using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Concepts.NeedForProperties
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _PassMark = 35;

        public int GetPassMark()
        {
            return this._PassMark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be empty or null");
            }
            this._Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No name" : this._Name;
        }

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student cannot be negative");
            }
            this._id = Id;
        }

        public int GetId()
        {
            return this._id;
        }
    }
}

   


