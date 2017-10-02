using System.Linq;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            return new T[length].Select(x=>x=item).ToArray();
        }
    }
}
