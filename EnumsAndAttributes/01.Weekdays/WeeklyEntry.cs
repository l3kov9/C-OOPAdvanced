using System;
using System.Collections;

namespace _01.Weekdays
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        private Weekday weekday;
        private string notes;

        public WeeklyEntry(string weekday, string notes)
        {
            this.weekday = (Weekday)Enum.Parse(typeof(Weekday), weekday);
            this.notes = notes;
        }
        public Weekday Weekday
        {
            get { return this.weekday; }
            set { this.weekday = value; }
        }

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public int CompareTo(WeeklyEntry other)
        {
            var result = this.Weekday.CompareTo(other.Weekday);

            if (result != 0)
            {
                return result;
            }

            return this.Notes.CompareTo(other.Notes);
        }

        public override string ToString()
        {
            return $"{this.Weekday} - {this.Notes}";
        }
    }
}
