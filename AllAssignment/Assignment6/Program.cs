namespace Assignment6
{

    using System;
    public class Date
    {
        private int day;
        private int month;
        private int year;

        // Default constructor
        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }

        // Parameterized constructor
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        // Properties
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        // AcceptDate method to accept data from console
        public void AcceptDate()
        {
            Console.Write("Enter day: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter month: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
        }

        // PrintDate method to print data to console
        public void PrintDate()
        {
            Console.WriteLine(ToString());
        }


        // ToString method to return data of object in string format
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }

        // Static method to return difference between two date objects in number of years
        public static int DifferenceInYears(Date date1, Date date2)
        {
            return Math.Abs(date1.year - date2.year);
        }

        // Overload "-" operator to perform the same job
        public static int operator -(Date date1, Date date2)
        {
            return DifferenceInYears(date1, date2);
        }
    }

    public class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        // Default constructor
        public Person()
        {
            name = "Unknown";
            gender = true;
            birth = new Date();
            address = "Unknown";
        }

        // Parameterized constructor
        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get
            {
                Date currentDate = new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                int age = currentDate - birth;
                return age;
            }
        }

        // Accept method to accept data from console
        public void Accept()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter gender (true for male, false for female): ");
            gender = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter birth date: ");
            birth.AcceptDate();

            Console.Write("Enter address: ");
            address = Console.ReadLine();
        }

        // Print method to print data to console
        public void Print()
        {
            Console.WriteLine(ToString());
        }

        // ToString method to return data of object in string format
        public override string ToString()
        {
            string genderStr = gender ? "Male" : "Female";
            return $"Name: {name}, Gender: {genderStr}, Birth Date: {birth}, Address: {address}, Age: {Age}";
        }
    }

    public class Program
    {
        public static void Main()
        {
           //("name", true, new Date(15, 7, 1995), "city");

            Person newPerson = new Person();
            newPerson.Accept();
            newPerson.Print();
        }
    }

}
