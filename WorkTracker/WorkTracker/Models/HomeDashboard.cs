using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public class HomeDashboard
    {
        public Dictionary<string, Employee> peopleMonitors = new Dictionary<string, Employee>();

        public HomeDashboard() {


        }

        public void DeleteMonitor(string key) {
            peopleMonitors.Remove(key);
        }

        public void AddMonitor(Employee monitor) {
            peopleMonitors.Add(monitor.empId, monitor);
        }

        //public Dictionary<string, IObserverMonitor> Gm()
        //{
        //    return this.peopleMonitors;
        //}

    }
}
