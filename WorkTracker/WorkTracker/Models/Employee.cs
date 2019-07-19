using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public class Employee : Person
    {
        public string empId { get; }
        public string contactNumber;
        public Dictionary<DateTime, TimeTrack> timeTracks { get; }
        public string jobTitle { get; set; }
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
            this.timeTracks.Add(tt.startTime, tt);
        }

        public void updateJobTitle(string job) {
            this.jobTitle = job;
        }
    }
}
