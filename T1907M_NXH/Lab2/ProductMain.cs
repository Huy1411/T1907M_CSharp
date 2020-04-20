using System;
using Microsoft.VisualBasic.CompilerServices;

namespace T1907M_NXH.Lab2
{
    public class ProductMain
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            int chose = 0;
            do
            {
                Console.WriteLine("1. AddProduct");
                Console.WriteLine("2. GetInfo");
                Console.WriteLine("3. CheckStock");
                Console.WriteLine("4. Add IMG");
                Console.WriteLine("5. Remove IMG");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Chose: ");
                chose = Convert.ToInt32(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        product.AddProduct(product);
                        break;
                    case 2:
                        product.GetInfo();
                        break;
                    case 3:
                        product.CheckStock();
                        break;
                    case 4:
                        product.AddImage();
                        break;
                    case 5:
                        product.RemoveImage();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            } while (chose != 5);
        }
    }
}