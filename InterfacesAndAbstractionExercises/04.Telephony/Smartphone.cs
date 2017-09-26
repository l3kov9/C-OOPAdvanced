using System;
using System.Linq;

namespace _04.Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        private string site;
        
        public Smartphone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            this.Site = "Unknown";
        }

        public Smartphone(string phoneNumber, string site)
            :this(phoneNumber)
        {
            this.Site = site;
        }

        public string PhoneNumber { get; }

        public string Site
        {
            get { return this.site; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("The site can't have any digits");
                }
                this.site = value;
            }
        }

        public void Call()
        {
            Console.WriteLine($"Calling ... {this.PhoneNumber}");
        }

        public void Browse()
        {
            
        }
    }
}
