using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            A x = new A(), y = new A();
            x.f();
            x.Report();
            y.f();
            y.Report();
        }
    }
}
