using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace CustomList
{
    public class Sorted
    {
        public static CustomList<T> Sort<T>(CustomList<T> data)
            where T: IComparable, IEnumerable
        {
            return data;
        }
    }
}
