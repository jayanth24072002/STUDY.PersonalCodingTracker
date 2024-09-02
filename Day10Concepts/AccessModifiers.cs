using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Concepts.AccessModifiers
{
    public class Customer
    {
        private int _id;
        protected int Id;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }

    public class CorporateCustomer : Customer
    {
        public void PrintId()
        {
            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 101;
        }
    }

}
