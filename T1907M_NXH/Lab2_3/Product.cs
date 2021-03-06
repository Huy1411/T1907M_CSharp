using System;
using System.Collections.Generic;

namespace T1907M_NXH.Lab2_3
{
    public class Product
    {
        protected int id;
        protected string name;
        protected int price;
        protected uint qty;
        protected string image;
        protected string desc;
        protected List<string> gallery;

        public Product()
        {
            this.gallery = new List<String>();
        }

        public Product(int id, string name,
            int price, uint qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public int Id // khai bao 1 properties
        {
            get { return id; } // ham tra ve gia tri - read
            set { this.id = value; } // ham set gia tri - write
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public int Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public uint Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID:" + id + " - Name: " + name + " - Price: " + price + " - Qty: " + qty +
                              " - Desc: " + desc);
        }

        public bool CheckStock()
        {
            if (qty > 0) return true;
            return false;
        }

        public bool AddGallery(string image)
        {
            if (gallery.Count > 10)
            {
                Console.WriteLine("Anh da vuot qua so luong. Can xoa bot");
                return false;
            }

            gallery.Add(image);
            return true;
        }

        public void DeleteGallery()
        {
            Console.WriteLine("Danh sach anh");
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine(i + "." + gallery[i]);
            }

            Console.WriteLine("Chon anh de xoa");
            int stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number < gallery.Count && number >= 0)
            {
                gallery.RemoveAt(number);
                return true;
            }

            return false;
        }
    }
}