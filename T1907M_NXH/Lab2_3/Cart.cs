using System.Collections.Generic;

namespace T1907M_NXH.Lab2_3
{
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> listProduct;
        private string city;
        private string country;

        public Cart(int id, string customer, double grandTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.listProduct = listProduct;
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public List<Product> ListProduct
        {
            get => listProduct;
            set => listProduct = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public bool AddProduct(Product product)
        {
            listProduct.Add(product);
            // them tien trong grandTotal
            return true;
        }

        public bool RemoveProduct(Product product)
        {
            // tru tien trong grandTotal
            return listProduct.Remove(product);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (Product p in listProduct)
            {
                grand += p.Price; // chay vao ham get properties
            }

            grand += ShippingFee(grand);
            this.GrandTotal = grand; // chay vao ham set properties
            return grandTotal;
        }

        public double ShippingFee(double grand)
        {
            if (country.Equals("VietNam") && city.Equals("HaNoi") || city.Equals("HCM"))
            {
                return grand *= 0.01;
            }
            else if (country.Equals("VietNam"))
            {
                return grand *= 0.02;
            }
            else
            {
                return grand *= 0.05;
            }
        }
    }
}