using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public class Employee : Person
    {
        public string empId;
        public string contactNumber { get; set; }
        public Dictionary<DateTime, TimeTrack> timeTracks;
        public Employee(string empId, string firstName, string lastName) : base(firstName, lastName)
        {
            this.empId = empId;

        }

        public void addContactNumber(string number)
        {
            this.contactNumber = number;
        }

        public void addTimeTrack(TimeTrack tt)
        {
            timeTracks.Add(tt.startTime, tt);
        }
    }
}
