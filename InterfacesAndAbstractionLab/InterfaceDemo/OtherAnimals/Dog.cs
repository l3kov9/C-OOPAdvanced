namespace InterfaceDemo
{
    public class Dog : IAnimall
    {
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string MakeNoise()
        {
            return "Bau";
        }
    }
}
