using System;

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
        public Array gallery;

        public Product()
        {
        }

        public Product(int id, string name, int price, int qty, string image, string desc, Array gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public void getInfo()
        {
            Console.WriteLine("ID " +id+ " - Name: " +name+ " - Price: " +price+ " - Qty: " +qty+ " - Desc: " +desc+ " - Gallery: " +gallery);
        }

        public void check()
        {
            if (qty > 0)
            {
                Console.WriteLine("ID: " +id+ " - Name: "+name+"=> còm hàng");
            }
            else
            {
                Console.WriteLine("ID: " +id+ " - Name: "+name+ "=> hết hàng");
            }
        }

        public void addImg()
        {
            
        }
    }
    
}