namespace T1907M_NXH.Session3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man m = new Man();
            m.Running();
            m.SayHello();
            m.SayHello("Chao em");
            Woman wn = new Woman();
            wn.Running();
        }
    }
}