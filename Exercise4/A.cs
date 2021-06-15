using System;

namespace Exercise4
{
    class A
    {
        static int n = 1;
        public void f()
        {
            n++;
        }
        public void Report()
        {
            Console.WriteLine(n.ToString());
        }
    }
}
