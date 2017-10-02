using System;
using System.Collections.Generic;

namespace Demo
{
    public class Startup
    {
        public static void Main()
        {
            var data=new MyCustomData<int>();

            data.Add(3);
            data.Add(22);
            Console.WriteLine(data.Count);

            var cat = new Cat("Pesho", 11);
            cat.Eat(1);
            cat.Eat("Mickey");
            cat.Eat('d');
            cat.Eat(true);
        }
    }
}
