using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Concepts.StringAndStringBuilder
{
   public class StringBuilderExample
    {
        public static void Stringbuilder()
        {
            string userString = string.Empty;
            for (int i = 1; i <= 10000; i++)
            {
                userString += i.ToString() + " ";
            }
        //    StringBuilder userString = new StringBuilder( "C#");
        //    userString.Append("video");
        //    userString.Append("Tutorial");
        //    userString.Append("for");
        //    userString.Append("Beginners");
            
            Console.WriteLine(userString);

        }
    }
}
