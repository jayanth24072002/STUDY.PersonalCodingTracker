using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Concepts.CustomTypeDictionary
{
    public class CountryCode
    {
        public string Code { get; }

        public CountryCode(string code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is CountryCode))
            {
                return false;
            }

            return StringComparer.OrdinalIgnoreCase.Equals(this.Code, ((CountryCode)obj).Code);
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Code);
        }
    }

    public class Ambassador
    {
        public CountryCode CountryCode { get; set; }
        public string Name { get; set; } 
        public int Age { get; set; }    
        
    }
}
