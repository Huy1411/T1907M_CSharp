using System;

namespace T1907M_NXH.Practial.Ex2
{
    public  class Animal
    {
        protected string name;
        protected int weight;

        public Animal()
        {
        }

        public Animal(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name : " + name + " Weight : " + weight);
        }

        public virtual void SetMe(string name, int weight)
        {
            
        }

    }
}