using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace T1907M_NXH.Lab2_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product(1,"san pham 1",3000,3,"anh 1","mo ta sp 1",new List<string>());
            p1.AddGallery("anh 2");
            Fashion f1 = new Fashion(1,"quan ao", 1500,3,"fashion.jpg","mo ta fs 1",new List<string>(),"red",40);
            Diamon d1 = new Diamon(1,"kim cuong 18 cara", 15500,1 , "diamon.iqg", "Kim cuong nhan tao",new List<string>(), 18 );
            
            Cart c1 = new Cart(1,"NXH", 0, new List<Product>(),"VietNam","NamDinh" );
            c1.AddProduct(p1);
            c1.AddProduct(f1);
            c1.AddProduct(d1);
            
            Console.WriteLine("Tong tien phai thanh toan " + c1.FinalTotal());

        }
    }
}