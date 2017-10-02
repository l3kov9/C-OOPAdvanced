using System;
using System.Collections.Generic;

namespace GenericSwapMethod
{
    public class GenericCollection<T>
    {
        private List<T> data;

        public GenericCollection()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public void RemoveAt(int index)
        {
            this.data.RemoveAt(index);
        }

        public void Insert(int index, T element)
        {
            this.data.Insert(index, element);
        }
        

        public void SwapElements(int firstIndex, int secondIndex)
        {
            var firstElement = this.data[firstIndex];
            var secondElement = this.data[secondIndex];

            data.RemoveAt(firstIndex);
            data.Insert(firstIndex, secondElement);

            data.RemoveAt(secondIndex);
            data.Insert(secondIndex, firstElement);
        }

        public void Print()
        {
            foreach (var element in this.data)
            {
                Console.WriteLine($"{element.GetType().FullName}: {element}");
            }
        }
    }
}
