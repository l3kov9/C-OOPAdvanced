using System;

namespace _04.CodingTracker
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,AllowMultiple =true)]
    public class SoftUniAttribute : Attribute
    {
        public SoftUniAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
