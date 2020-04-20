using System;

namespace T1907M_NXH.Session3
{
    public abstract class Human
    {
        protected string name;
        protected int age;

        public abstract void AddFriend();

        public virtual void Running()
        {
            Console.WriteLine("Run....");
        }
        public void Eat()
        {
            Console.WriteLine("Eating....");
        }
        
    }
}