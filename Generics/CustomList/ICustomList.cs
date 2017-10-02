namespace CustomList
{
    public interface ICustomList<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int firstIndex, int secondIndex);

        int CountGreaterThan(T element);

        T Max();

        T Min();
    }
}
