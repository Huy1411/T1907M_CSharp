using System;

namespace T1907M_NXH.Ass4
{
    public class DomesticCustomer : Customer
    {
        protected string subject;
        protected string nationality;

        public DomesticCustomer()
        {
        }

        public DomesticCustomer(int id, string name, string dateofinvoice, int qty, string nationality, string subject)
            : base(id, name, dateofinvoice, qty,nationality)
        {
            this.subject = subject;
            this.nationality = nationality;
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
            if (nationality.Equals("VietNam"))
            {
                return total = qty * 2000;
            }

            return total;
        }
    }
}