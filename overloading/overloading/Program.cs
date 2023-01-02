using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition num = new Addition();
            num.Add(20);
            num.Add(10,20);
            num.Add(10, 45.32);
            num.Add(4, " students");
            num.Add(10, 6.4, "degree");

            Console.ReadKey();
        }
    }
}
