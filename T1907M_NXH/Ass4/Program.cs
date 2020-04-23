using System;
using System.Collections.Generic;

namespace T1907M_NXH.Ass4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "NXH", "30-04-2020", 50, "VietNam");
            Customer c2 = new Customer(2, "DTN", "30-04-2020", 200, "VietNam");
            Customer c3 = new Customer(3, "HTH", "30-04-2020", 150, "EngLand");
            Customer c4 = new Customer(4, "HPD", "30-04-2020", 200, "Russia");
            Bill b1 = new Bill(1,0,0,new List<Customer>());
            b1.AddCustomer(c1);
            b1.AddCustomer(c2);
            b1.AddCustomer(c3);
            b1.AddCustomer(c4);
            
            Console.WriteLine("Tong tien cua khach hang trong nuoc  : " + b1.FinalTotal1());
            Console.WriteLine("Tong tien cua khach hang nuoc ngoai : " + b1.FinalTotal2());
        }
    }
}