using System;
using System.Collections;
using System.Collections.Generic;

//import

namespace T1907M_NXH //package
{
    class Program
    {
        static void Main(string[] args)
        
        {
            // Console.WriteLine("Hello World!"); //print
            // string str;
            // str = Console.ReadLine();
            
            // TotalNumber();
            dynamic x; // kieu du lieu dong
            x = 20;
            Console.WriteLine(x+15);
            x = "Hello";
            Console.WriteLine(x+15);
            // Fibonacci();
        }

        static void TotalNumber()
        {
            int numberOne = 2;
            int numberTwo;
            if (numberOne > 2)
            {
                numberTwo = 2;
            }
            else
            {
                numberTwo = 1;
            }

            numberTwo = numberOne > 2 ? 2 : 1;

            int[] arr = {1, 2, 3, 4};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (int y in arr)
            {
                Console.WriteLine(y);
            }

            double[] arr2 = new double[5];
            arr2[0] = 1.12;
            arr2[1] = 2.112;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("add");
            List<int> list = new List<int>();
            list.Add(5); //them thong thuong cua list
            list[1] = 6; // Them kieu chi muc index
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int k in list)
            {
                Console.WriteLine(k);
            }
        }

        static void Fibonacci()
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