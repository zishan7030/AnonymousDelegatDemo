using System;

namespace AnonymousDelegatDemo
{
    class Program
    {
        //Declaring Delegates
        public delegate void Delsum(int a, int b);
        public delegate void DelSquare(int a);
        static void Main(string[] args)
        {
            //Using Delegate Anonymously Without Refering to any Method
            Delsum ds = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            ds(22, 20);             //Passing Values
            DelSquare ds1 = delegate (int a)
              {
                  Console.WriteLine(a * a);
              };
            ds1(4);
        }
    }
}
