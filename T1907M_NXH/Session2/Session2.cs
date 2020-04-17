using System;

namespace T1907M_NXH.Session2
{
    public class Session2
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student(); // s1 la 1 doi tuong tao ra tu lop Student 
            // new Student() moi la 1 doi tuong  -> tao 1 o chua : name,age, function showInfo
            s1.showInfo();
            s1.showName();
            Social.Hello(); //ClassName.MethodName()
            Console.WriteLine(Social.FindWeekOfYear+10);//ClassName.VarName
        }
    }
}