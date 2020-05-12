using System;

namespace T1907M_NXH.Practial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double height;
            Clynder cl = new Clynder();
            Console.WriteLine("Enter Radius :");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height :");
            height = Convert.ToDouble(Console.ReadLine());
            cl.Process(radius,height);
            cl.Result(radius,height);
        }
    }
}