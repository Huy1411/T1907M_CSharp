using System;

namespace T1907M_NXH.Session6
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("a + b = " + (a+b));
            return a+b;
            
        }

        public static int Subtract(int a, int b)
        {
            Console.WriteLine("a - b = " + (a-b));
            return a-b;
        }

        public int division(int a, int b)
        {
            if (b == 0) return 0;
            Console.WriteLine("a : b = " + (a/b));
            return a/b;
        } 
    }
}