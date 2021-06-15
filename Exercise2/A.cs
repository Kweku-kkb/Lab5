using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class A
    {
        protected int n = 1;
        public A()
        {
            n++;
            Console.WriteLine("n= "+ n.ToString());
        }
    }
}
