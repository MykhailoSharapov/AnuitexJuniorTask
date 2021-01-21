using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuitexJuniorTask
{
    public abstract class Employee
    {
        public Employee(string fullName, int expierence)
        {
            this.FullName = fullName;
            this.expierence = expierence;
        }
        public string FullName { get; set; }

        public int expierence { get; set; }

        public abstract void Work();
    }
}
