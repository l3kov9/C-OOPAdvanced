using System;

namespace AttributesDemo
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.All)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Year { get; set; }
    }
}
