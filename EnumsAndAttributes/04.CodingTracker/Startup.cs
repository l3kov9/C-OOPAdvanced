namespace _04.CodingTracker
{
    public class Startup
    {
        [SoftUni("Lekov")]
        public class StartUp
        {
            [SoftUni("Pesho")]
            public static void Main(string[] args)
            {
                var tracker = new Tracker();
                tracker.PrintMethodsByAuthor();
            }

        }
    }
}
