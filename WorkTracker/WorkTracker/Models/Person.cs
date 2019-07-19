using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public abstract class Person : IObserverMonitor
    {
        public string firstName;
        public string lastName;
        public Person(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;
        }
    }
}
