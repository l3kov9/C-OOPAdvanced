namespace InterfaceDemo
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; }
        public string Color { get; }
        public string SayHello()
        {
            throw new System.NotImplementedException();
        }
    }
}
