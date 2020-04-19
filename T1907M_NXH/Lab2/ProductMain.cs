using System;

namespace T1907M_NXH.Lab2
{
    public class ProductMain
    {
        public static void Main(string[] args)
        {
            Product product1= new Product(1,"Apple",56,1,"","Ha Noi");
            product1.getInfo();
            product1.checkInfo();
            product1.addImg();
            product1.deleteImg();
        }
    }
}