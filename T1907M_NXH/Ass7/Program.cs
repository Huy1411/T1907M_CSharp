using System;

namespace T1907M_NXH.Ass7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            int choose;
            do
            {
                ShowMenu();
                choose = ReadNumber();
                if (choose > 0 && choose < 7)
                {

                    switch (choose)
                    {
                        case 1:
                            student.AddStudent();
                            break;
                        // case 2:
                        //     student.;
                        //     break;
                        case 3:
                            student.DeleteID();
                            break;
                        case 4:
                            student.SortByGpa();
                            break;
                        case 5:
                            student.SortByName();
                            break;
                        case 6:
                            student.ShowStudent();
                            break;
                    }
                }
            } while (choose != 0);
        }
        public static void ShowMenu()
        {
            Console.WriteLine("\nAvaiable action: \n press");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Edit student by id.");
            Console.WriteLine("3. Delete student by id.");
            Console.WriteLine("4. Sort student by gpa.");
            Console.WriteLine("5. Sort student by name.");
            Console.WriteLine("6. Show student.");
            Console.WriteLine("0. Exit");
        }

        public static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}