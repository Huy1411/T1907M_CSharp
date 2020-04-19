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
        public List<String> gallery;

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

        public void getInfo()
        {
            Console.WriteLine("ID:" +id+ " - Name: " +name+ " - Price: " +price+ " - Qty: " +qty+ " - Desc: " +desc);
        }

        public void checkInfo()
        {
            if (qty > 0)
            {
                Console.WriteLine("ID: " +id+ " - Name: "+name+" => còn hàng");
            }
            else
            {
                Console.WriteLine("ID: " +id+ " - Name: "+name+ "=> hết hàng");
            }
        }

        public void addImg()
        {
            
            List<String> gallery = new List<string>();
            gallery.Add("");
            foreach (String g in gallery)
            {
                Console.WriteLine(g);
            }
        }

        public void deleteImg()
        {
            
        }
    }
    
}