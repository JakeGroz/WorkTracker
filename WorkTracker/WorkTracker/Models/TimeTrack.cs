using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTracker.Models
{
    public class TimeTrack
    {
        private DateTime startTime { get; set; }
        private DateTime endTime { get; set; }
        private List<DateTime> breakStartTimes { get; }
        private List<DateTime> breakEndTimes { get; }

        public void addBreakStartTime (DateTime time)
        {
            breakStartTimes.Add(time);
        }
        public void addBreakEndTime(DateTime time)
        {
            breakStartTimes.Add(time);
        }
        public void editBreakStart(DateTime time, int position)
        {
            breakStartTimes[position] = time;
        }
        public void editBreakEnd(DateTime time, int position)
        {
            breakEndTimes[position] = time;
        }

    }
}
