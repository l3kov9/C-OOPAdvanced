namespace _06.StrategyPattern
{
    public class Person
    {
        public string Name;

        public int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
