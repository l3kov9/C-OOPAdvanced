using System;
using System.Collections;
using System.Collections.Generic;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private readonly List<int> stones;

        public Lake(IEnumerable<int> stones)
        {
            this.stones = new List<int>(stones);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                    yield return this.stones[i];
            }

            int reversedCounter = (this.stones.Count - 1) % 2 == 0 ? this.stones.Count - 2 : this.stones.Count - 1;

            for (int i = this.stones.Count-1; i >= 0; i-=2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
