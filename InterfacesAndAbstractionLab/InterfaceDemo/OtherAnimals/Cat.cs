using System.Collections.Generic;

namespace InterfaceDemo
{
    public class Cat : IAnimall, IMammal
    {         
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string MakeNoise()
        {
            return "Ohhh";
        }

        public bool HaveABaby()
        {
            throw new System.NotImplementedException();
        }

        public void IAmAMammal()
        {
            throw new System.NotImplementedException();
        }
    }
}
