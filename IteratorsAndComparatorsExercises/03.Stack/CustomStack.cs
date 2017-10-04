using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> data;

        public CustomStack()
        {
            this.data = new List<T>();
        }

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public void Pop()
        {
            if (this.data.Count > 0)
            {
                this.data.RemoveAt(this.data.Count - 1);
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
