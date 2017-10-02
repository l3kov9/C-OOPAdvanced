using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    public class CustomList<T>
        where T:IComparable, IEnumerable
    {
        private List<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public int Count => this.data.Count;

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public int CountGreaterThan(T element)
        {
            return this.data.Count(x => x.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public T Remove(int index)
        {
            var element = this.data[index];
            this.data.RemoveAt(index);
            return element;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstElement = this.data[firstIndex];
            var secondElement = this.data[secondIndex];

            this.data.RemoveAt(firstIndex);
            this.data.Insert(firstIndex, secondElement);

            this.data.RemoveAt(secondIndex);
            this.data.Insert(secondIndex, firstElement);
        }

        public void Print()
        {
            this.data
                .ForEach(x=>Console.WriteLine(x));
        }
    }
}
