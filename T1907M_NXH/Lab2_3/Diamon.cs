using System.Collections.Generic;

namespace T1907M_NXH.Lab2_3
{
    public class Diamon:Product
    {
        private uint cara;

        public Diamon(int id, string name, int price, uint qty, string image, string desc, List<string> gallery, uint cara) : base(id, name, price, qty, image, desc, gallery)
        {
            this.cara = cara;
        }

        public uint Cara
        {
            get { return cara + 10; }
            set
            {
                if (cara > 5)
                {
                    cara = value;
                }
                else
                {
                    cara = 5;
                }
            }
        }

        public bool IsReal()
        {
            //Cong thuc kiem tra
            if(cara >5) return true;
            return false;
        }
    }
}