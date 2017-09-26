namespace _05.BorderControl
{
    public interface IIdentifiable
    {
        string Id { get; }

        bool IsValidId(string pattern);
    }
}
