using System;
using System.Collections.Generic;

namespace _01.Weekdays
{
    public class WeeklyCalendar
    {
        public List<WeeklyEntry> WeeklySchedule;

        public WeeklyCalendar()
        {
            this.WeeklySchedule = new List<WeeklyEntry>();
        }

        public void AddEntry(string weekday, string notes)
        {
            var weeklyEntry = new WeeklyEntry(weekday, notes);
            this.WeeklySchedule.Add(weeklyEntry);
        }
    }
}
