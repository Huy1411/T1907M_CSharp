using System;
using System.Collections.Generic;
using T1907M_NXH.Lab2;

namespace T1907M_NXH.Ass3
{
    public class Cart : Product
    {
        public int id;
        public string customer;
        public double grantTotal;
        public string city;
        public string country;
        public List<Product> productList = new List<Product>();
        public List<double> totals = new List<double>();


        public Cart()
        {
        }

        public Cart(int id, string name, int price, int qty, string image, string desc, string iD, string customer,
            double grantTotal, string city, string country) : base(id, name, price, qty, image, desc)
        {
            this.id = id;
            this.customer = customer;
            this.grantTotal = grantTotal;
            this.city = city;
            this.country = country;
        }

        public void AddProduct()
        {
            Product product = new Product();
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
        
        public void showInfo()
        {
            Console.WriteLine("======Customer List======= ");
            Console.WriteLine("Customer id: " + id + " - Name: " + customer + " - City: " + city + " - Country: " +
                              country);
            foreach (Product p in productList)
            {
                Console.WriteLine("ID: " + p.id + " - Name: " + p.name + " - Price: " + p.price + " - Qty: " + p.qty +
                                  " - Image: " + p.image + " - Desc: " + p.desc);
            }
        }

        public void RemoveProduct()
        {
            string removeName;
            Console.WriteLine("Nhap san pam muon xoa: ");
            removeName = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < productList.Count; i++)
            {
                if (removeName.Equals(productList[i].name))
                {
                    productList.RemoveAt(i);
                    Console.WriteLine("Da xoa thanh cong");
                }
                else
                {
                    Console.WriteLine("Khong co ten cua san pham tren!");
                }
            }
        }

        public void grandTotalCal()
        {
            foreach (Product p in productList)
            {
                grantTotal = p.price * p.qty;
                totals.Add(grantTotal);
            }


            double fee;
            if (country == "VietNam")
            {
                if (city == "Ha Noi" | city == "HCM")
                {
                    fee = grantTotal * 0.01;
                    Console.WriteLine("Tong tien chua bao gom phi ship: " + grantTotal);
                    Console.WriteLine("Phi ship:  " + (fee));
                    Console.WriteLine("Tong tien:" + (grantTotal + fee));
                }
                else
                {
                    fee = grantTotal * 0.02;
                    Console.WriteLine("Tong tien chua bao gom phi ship: " + grantTotal);
                    Console.WriteLine("Phi ship:  " + (fee));
                    Console.WriteLine("Tong tien:" + (grantTotal + fee));
                }
            }
            else
            {
                fee = grantTotal * 0.05;
                Console.WriteLine("Tong tien chua bao gom phi ship: " + grantTotal);
                Console.WriteLine("Phi ship:  " + (fee));
                Console.WriteLine("Tong tien:" + (grantTotal + fee));
            }
        }
    }
    
}