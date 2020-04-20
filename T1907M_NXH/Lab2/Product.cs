using System;
using System.Collections.Generic;

namespace T1907M_NXH.Lab2
{
    public class Product
    {
        public int id; //id, name, price, qty, image, desc, gallery < string array>
        public String name;
        public int price;
        public int qty;
        public String image;
        public String desc;
        private List<string> gallery = new List<string>();
        public List<Product> productList = new List<Product>();

        public Product()
        {
        }

        public Product(int id, string name, int price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public void GetInfo()
        {
            foreach (Product p in productList)
            {
                Console.WriteLine("ID:" + id + " - Name: " + name + " - Price: " + price + " - Qty: " + qty +
                                  " - Desc: " + desc);
            }
        }
        public void AddProduct(Product product)
        {
            Console.WriteLine("Enter id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter qty: ");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter image: ");
            image = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter desc: ");
            desc = Convert.ToString(Console.ReadLine());
            productList.Add(new Product(id, name, price, qty, image, desc));
            Console.WriteLine("Them san pham thanh cong");
        }

        public void CheckStock()
        {
            string name;
            Console.WriteLine("San pham can tim: ");
            name = Convert.ToString(Console.ReadLine());
            foreach (Product p in productList)
            {
                if (name.Equals(p.name))
                {
                    if (p.qty > 0)
                    {
                        Console.WriteLine("Con hang");
                    }
                    else
                    {
                        Console.WriteLine("Het hang");
                    }
                }
            }
        }

        public void AddImage()
        {
            if (gallery.Count < 10)
            {
                foreach (Product p in productList)
                {
                    gallery.Add(p.image);
                }
                Console.WriteLine("Them thanh cong vao ");
                Console.WriteLine("List gallery: ");
                foreach (String img  in gallery)
                {
                    Console.WriteLine(img);
                }
            }
            else
            {
                Console.WriteLine("Vuot qua so luong them");
            }
            
        }

        public void RemoveImage()
        {
            Console.WriteLine("Danh sach anh: ");
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine("STT: " + (i+1) + "\n IMG: " + gallery[i]);
            }

            int index;
            Console.WriteLine("Nhap vi tri muon xoa: ");
            index = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gallery.Count; i++)
            {
                if (i == index)
                {
                    gallery.RemoveAt(index - 1);
                    Console.WriteLine("Xoa thanh cong!");
                    Console.WriteLine("Gallery list: ");
                    foreach (string img in gallery)
                    {
                        Console.WriteLine(img);
                    }
                }
            }

        }
        
    }
    
}