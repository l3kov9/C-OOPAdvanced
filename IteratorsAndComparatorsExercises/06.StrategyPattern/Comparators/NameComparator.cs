using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.StrategyPattern.Comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var result = x.Name.Length.CompareTo(y.Name.Length);

            if (result != 0)
            {
                return result;
            }

            return x.Name[0].ToString().ToUpper().CompareTo(y.Name[0].ToString().ToUpper());
        }
    }
}
