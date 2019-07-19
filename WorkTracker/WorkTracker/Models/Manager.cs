using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public class Manager : Person
    {
        public string managerId;

        public Manager(string manId, string firstName, string lastName) : base(firstName, lastName)
        {
            this.managerId = manId;
        }

}


       
    }
}
