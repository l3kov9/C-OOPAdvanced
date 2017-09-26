using System;
using System.Collections.Generic;

namespace _04.Telephony
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                var smartPhones=new List<Smartphone>
                {
                    new Smartphone("0812","Softuni.bg"),
                    new Smartphone("0122002042","dad923as.com"),
                    new Smartphone("0812","Softuni.bg"),
                };

                smartPhones.ForEach(x => x.Call());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
