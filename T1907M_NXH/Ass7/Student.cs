using System;
using System.Collections.Generic;

namespace T1907M_NXH.Ass7
{
    public class Student
    {
        public int id;
        public string? name;
        public int age;
        public double gpa;
        public List<Student> students = new List<Student>();

        public Student()
        {
        }

        public Student(int id, string name, int age, double gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gpa = gpa;
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

        public int Age
        {
            get => age;
            set => age = value;
        }

        public double Gpa
        {
            get => gpa;
            set => gpa = value;
        }

        public List<Student> Students
        {
            get => students;
            set => students = value;
        }

        public void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Enter id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter gpa: ");
            gpa = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowStudent()
        {
            foreach (Student s in students)
            {
                Console.WriteLine("ID: " + id + " - Name: " + name + " - Age: " + age + " - Gpa: " + gpa);
            }
            
        }
        public void DeleteID()
        {
            Console.WriteLine("Chon id de xoa");
            int stt = Convert.ToInt32(Console.ReadLine());
            students.RemoveAt(stt);
        }

        public bool SortByGpa()
        {
            Console.WriteLine("Chon diem trung binh de tim");
            int diemtb = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < students.Count; i++)
            {

                if (diemtb.Equals(gpa))
                {
                    Console.WriteLine("ID: " + id + " - Name: " + name + " - Age: " + age + " - Gpa: " + gpa);
                    return true;
                }
            }
            Console.WriteLine("Khong tin thay");
            return false;
        }
        
        public bool SortByName()
        {
            Console.WriteLine("Chon ten de tim");
            string ten = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < students.Count; i++)
            {

                if (ten.Equals(name))
                {
                    Console.WriteLine("ID: " + id + " - Name: " + name + " - Age: " + age + " - Gpa: " + gpa);
                    return true;
                }
            }
            Console.WriteLine("Khong tin thay");
            return false;
        }
    }
}