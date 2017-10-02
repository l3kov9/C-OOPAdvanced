using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T> : IBox<T>
    {
        private List<T> data;

        public Box()
        {
            this.data=new List<T>();
        }

        public void Add(T element)
        {
            data.Insert(0,element);
        }

        public T Remove()
        {
            T removingElement = data[data.Count - 1];
            data.RemoveAt(data.Count-1);
            return removingElement;
        }

        public int Count => this.data.Count;
    }
}
