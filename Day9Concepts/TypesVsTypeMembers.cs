using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.TypesVsTypeMembers
{
    #region Fields
    public class Customer
    {
        private int _id;
        private string _FirstName;
        private string _LastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this._FirstName + " " + this._LastName;
        }
        #endregion
    }
}
