using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public class HomeDashboard : IDashboard
    {
        private Dictionary<string, IObserverMonitor> peopleMonitors = new Dictionary<string, IObserverMonitor>();
        public HomeDashboard() {
        }

        public void DeleteMonitor(string key) {
            peopleMonitors.Remove(key);
        }

        public void AddMonitor(Employee monitor) {
            peopleMonitors.Add(monitor.empId, monitor);
        }

    }
}
