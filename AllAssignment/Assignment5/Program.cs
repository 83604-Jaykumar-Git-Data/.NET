using System;

namespace Assignment5
{
    internal class Program
    {
        static Student[] students;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CreateArray();
            AcceptInfo();
            Console.WriteLine("\nStudent Information:");
            PrintInfo();
            ReverseArray();
            Console.WriteLine("\nReversed Student Information:");
            PrintInfo();
        }
        static void CreateArray()
        {
            Console.Write("Enter the number of students: ");
            int numStudents = Convert.ToInt32(Console.ReadLine());
            students = new Student[numStudents];
        }
        static void AcceptInfo()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nEnter details for student {i + 1}:");
                students[i].AcceptDetails();
            }
        }
        static void PrintInfo()
        {
            foreach (var student in students)
            {
                student.PrintDetails();
                Console.WriteLine();
            }
        }
        static void ReverseArray()
        {
            Student[] reversedArray = new Student[students.Length];
            for (int i = 0, j = students.Length - 1; i < students.Length; i++, j--)
            {
                reversedArray[i] = students[j];
            }
            students = reversedArray;
        }
    }

    public struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public void AcceptDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (true for male, false for female): ");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Standard: ");
            std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Division: ");
            div = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + (gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Standard: " + std);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Marks: " + marks);
        }
    }


}
