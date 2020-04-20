using System;
using System.Collections.Generic;
using T1907M_NXH.Lab2;

namespace T1907M_NXH.Lab3
{
    public class Fashion: Product
    {
        public string color;
        public string size;
        public List<Fashion> fashionList=new List<Fashion>();

        public Fashion(string color, string size)
                 {
                     this.color = color;
                     this.size = size;
                 }

        public Fashion()
        {
            
        }

        public Fashion(int id, string name, int price, int qty, string image, string desc) : base(id, name, price, qty, image, desc)
        {
            
        }

        public void InsertFashion(string color, string size)
        {
            foreach (Product p in productList)
            {
                if (name.Equals(p.name))
                {
                    return;
                }
            }
            fashionList.Add(new Fashion(color, size));
        }

        public void ShowFashion()
        {
            Console.WriteLine("Fashion List:");
            foreach (Fashion f in fashionList)
            {
                Console.WriteLine("ID:" + id + " - Name: " + name + " - Price: " + price + " - Qty: " + qty +
                                  " - Desc: " + desc + " - Color: " + color + " - Size " + size);
            }
        }

        public void CheckFashion()
        {
            string name;
            Console.WriteLine("San pham can tim: ");
            name = Convert.ToString(Console.ReadLine());
            foreach (Fashion f in productList)
            {
                if (name.Equals(f.name))
                {
                    if (f.qty > 0)
                    {
                        Console.WriteLine("Con hang");
                        string color;
                        Console.WriteLine("Mau can tim: ");
                        color = Convert.ToString(Console.ReadLine());
                        if (color.Equals(f.color))
                        {
                            Console.WriteLine("ID:" + id + " - Name: " + name + " - Price: " + price + " - Qty: " +
                                              qty +
                                              " - Desc: " + desc + " - Color: " + color + " - Size " + size);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Het hang");
                    }
                }
                
            }
        }
    }
}