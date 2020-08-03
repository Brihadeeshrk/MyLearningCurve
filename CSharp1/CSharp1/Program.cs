using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));
        }
    }
}
