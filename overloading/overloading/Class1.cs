using System;
using System.Collections.Generic;
using System.Text;

namespace overloading
{
    class Addition
    {
        public void Add(int a)
        {
            Console.WriteLine("Addition is " + a);
        }
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is " + c);
        }
        public void Add(int a,double c)
        {
            double b = (double)(a + c);
            Console.WriteLine("Addition is " + b);
        }
        public void Add(int a , string m)
        {
            Console.WriteLine("Addition is " + a+m);
        }
        public void Add(int a,double b,string c)
        {
            double d = (double)a + b;
            Console.WriteLine("Addition is " + d +c);
        }
    }
}
