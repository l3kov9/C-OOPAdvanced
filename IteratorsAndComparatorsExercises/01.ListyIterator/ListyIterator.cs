using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;

        private int currentIndex;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.currentIndex = 0;
        }

        public ListyIterator(IEnumerable<T> collection)
        {
            this.data = new List<T>(collection);
            this.currentIndex = 0;
        }

        public bool Move()
        {
            return ++currentIndex >= this.data.Count ? false : true;
        }

        public bool HasNext()
        {
            if (currentIndex + 1 >= this.data.Count)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.data[this.currentIndex]);
        }

        public void PrintAll()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < data.Count; i++)
            {
                sb.Append(data[i] + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < data.Count; i++)
            {
                 yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
