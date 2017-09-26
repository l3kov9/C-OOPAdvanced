namespace AbstractionDemo.Animals
{
    public abstract class Animal
    {
        public const int NumberOfEyes = 2;
        public readonly int NumberOfLegs=15;

        public string Name { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public abstract string SayHello();
    }
}
