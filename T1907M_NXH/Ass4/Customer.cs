using System;
using System.Collections.Generic;
using T1907M_NXH.Lab2;

namespace T1907M_NXH.Ass4
{
    public class Customer
    {
        protected int id;
        protected string name;
        protected string dateofinvoice;
        protected int qty; // so luong
        protected string nationality;
        protected List<Customer> listCustomner;


        public Customer()
        {
        }

        public Customer(int id, string name, string dateofinvoice, int qty, string nationality)
        {
            this.id = id;
            this.name = name;
            this.dateofinvoice = dateofinvoice;
            this.qty = qty;
            this.nationality = nationality;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Dateofinvoice
        {
            get => dateofinvoice;
            set => dateofinvoice = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public double Total1()
        {
            double total = 0;
            if (nationality.Equals("VietNam"))
            {
                if (qty <= 50)
                {
                    total = qty * 1000;
                }

                if (50 < qty && qty < 100)
                {
                    total = qty * 1000 + (qty - 50) * 1200;
                }

                if (100 < qty && qty < 200)
                {
                    total = qty * 1000 + (qty - 50) * 1200 + (qty - 100) * 1500;
                }

                if (qty > 200)
                {
                    total = qty * 1000 + (qty - 50) * 1200 + (qty - 100) * 1500 + (qty - 200) * 2000;
                }
            }
            return total;
        }

        public double Total2()
        {
            double total = 0;
            if (nationality != ("VietNam"))
            {
                return total = qty * 2000;
            }

            return total;
        }
    }
}