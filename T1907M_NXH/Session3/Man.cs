using System;

namespace T1907M_NXH.Session3
{
    public class Man: Human, IHuman
    {
        public override void AddFriend()
        {
            
        }

        public void Alo()
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine("Hello Everybody !!!");
        }

        public void SayHello(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}