using System;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            var color = Color.Blue;
            color = (Color)220;

            var task = new Task();
            task.State = TaskState.Pending;

            var today = DayOfWeek.Thursday;

            var daysOfWeek = Enum.GetValues(typeof(DayOfWeek));
            var namesOfWeek = Enum.GetNames(typeof(DayOfWeek)); 

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
