using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoComparators
{
    public class CustomEqualityComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            return x != y;
        }

        public int GetHashCode(int obj)
        {
            throw new NotImplementedException();
        }
    }
}
