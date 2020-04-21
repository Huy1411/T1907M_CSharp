using T1907M_NXH.Lab2;

namespace T1907M_NXH.Ass3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.AddProduct();
            cart.showInfo();
            cart.grandTotalCal();
        }
    }
}