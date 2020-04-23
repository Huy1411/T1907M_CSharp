using System.Collections.Generic;
using System.Reflection.Metadata;

namespace T1907M_NXH.Ass4
{
    public class Bill
    {
        private int id;
        private double grandTotal;
        private double qtyTotal;
        private List<Customer> listCustomner;

        public Bill(int id, double grandTotal, double qtyTotal, List<Customer> listCustomner)
        {
            this.id = id;
            this.grandTotal = grandTotal;
            this.qtyTotal = qtyTotal;
            this.listCustomner = listCustomner;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public double QtyTotal
        {
            get => qtyTotal;
            set => qtyTotal = value;
        }

        public List<Customer> Customers
        {
            get => listCustomner;
            set => listCustomner = value;
        }


        public bool AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            return true;
        }

        public double FinalTotal1()
        {
            double grand = 0;
            foreach (Customer dc in listCustomner)
            {
                grand += dc.Total1();
            }

            this.grandTotal = grand;
            return grandTotal;
        }

        public double FinalTotal2()
        {
            double grand = 0;
            foreach (Customer c in listCustomner)
            {
                grand += c.Total2();
            }

            this.grandTotal = grand;
            return grandTotal;
        }
        
    }
}