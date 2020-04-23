using System.Collections.Generic;

namespace T1907M_NXH.Lab2_3
{
    public class Fashion : Product
    {
        private string color;
        private int size;

        public Fashion(int id, string name, int price, uint qty, string image, string desc, List<string> gallery,
            string color, int size) : base(id, name, price, qty, image, desc, gallery)
        {
            this.color = color;
            this.size = size;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public int Size
        {
            get => size;
            set => size = value;
        }

        public bool CheckColor(string color)
        {
            if (this.color.Equals(color) && this.qty > 0)
            {
                return true;
            }

            return false;
        }

        public bool CheckSize(int size)
        {
            if (this.size.Equals(size) && this.qty > 0)
            {
                return true;
            }

            return false;
        }
    }
}