using System;

namespace Exercise8
{
    abstract class A
    {
        int x;
        public abstract void f(int n);
        public virtual void g(uint n) // method cannot be private because its virtual
        {
            /* x = n as int; // error */
            x = (int)n;
        }
        public string ToString()
        {
            return x.ToString();
        }

    }
}
