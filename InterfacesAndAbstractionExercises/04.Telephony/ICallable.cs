namespace _04.Telephony
{
    public interface ICallable
    {
        string PhoneNumber { get; }

        void Call();
    }
}
