using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.Tuples
{
    public class TupleExample
    {
        public  (int empId, string empName, double Salary) GetEmployeeDetails()
        {
            var em = (eid: 0, ename: string.empty, salary: 0);
            em.eid = 1321;
            em.ename = "jay";
            em.salary = 7000;

            return em;
        }
    }
}
