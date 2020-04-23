using System;

namespace T1907M_NXH.Lab1
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            Fibonacci();
        }
        public static void Fibonacci()
        {
            int n;
            Console.WriteLine("Nhap so n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int f = 0;
            int f1 = 1, f2 = 1 ;
            while (f1 + f2 < n)
            {
                f = f1 + f2;
                f2 = f1;
                f1 = f;
            }
            Console.WriteLine("Number = " + n + " => Fibonacci = " +f);
        }
    }
}