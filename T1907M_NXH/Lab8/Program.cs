using System;
using System.Threading;

namespace T1907M_NXH.Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new Program().ThreadRun);
            t1.Start();
        }

        public void ThreadRun(object o)
        {
            int n = (int) o;
            for (int minute = n-1; minute >= 0; minute--)
            {
                for (int second = 59; second >= 0; second--)
                {
                    Console.WriteLine(minute.ToString("D2") + ":" + second.ToString("D2"));
                }
            }

            Console.WriteLine("Booommmmmmm");
        }
    }
}