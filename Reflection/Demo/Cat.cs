namespace Demo
{
    public class Cat : Animal
    {
        public string somePublicField;
        private string somePrivateField;
        private static string someStaticField;

        public string Name { get; set; }

        public int Age { get; set; }

        public Cat()
        {
            this.Name = "Pesho";
        }

        public Cat(string name)
        {
            this.Name = name;
        }

        public Cat(string name, int age)
            :this(name)
        {
            this.Age = age;
        }
    }
}
