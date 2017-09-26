namespace InterfaceDemo
{
    public partial interface IAnimal
    {
        string Name { get; }

        string Color { get; }

        string SayHello();
    }
}
