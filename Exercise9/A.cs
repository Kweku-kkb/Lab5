using System;

namespace Exercise9
{
    class A
    {
        int n;
        string s;
        public A(int n)
        {
            this.n = n;
        }
        public int getNum()
        {
            return n;
        }
        public static void Main(string[] args)
        {
            A[] v = new A[10];
            for(int i = 0; i < v.Length; i++)
            {
                v[i] = new A(10 - i);
            }

            foreach(A element in v)
            {
                Console.Write(element.getNum());
            }

            Array.Sort(v, delegate (A a, A b) { return a.getNum().CompareTo(b.getNum()); });
            
            Console.WriteLine("\nSorted elements");
            
            foreach (A element in v)
            {
                Console.Write(element.getNum());
            }
        }
        

    }
}
