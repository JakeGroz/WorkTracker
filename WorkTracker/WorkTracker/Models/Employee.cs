using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public class Employee : Person
    {
        static private int empId = 0;
        public string contactNumber { get; set; }
        public List<TimeTrack> timeTracks;
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public void addContactNumber(string number)
        {
            this.contactNumber = number;
        }

        public void addTimeTrack(TimeTrack tt)
        {
            timeTracks.Add(tt);
        }
    }
}
