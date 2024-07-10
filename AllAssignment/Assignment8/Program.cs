namespace Assignment8
{
    using System;


    public class Person
    {
        private string name;
        private bool gender;
        private string address;

        // Default constructor
        public Person()
        {
            name = "Unknown";
            gender = true;
            address = "Unknown";
        }

        // Parameterized constructor
        public Person(string name, bool gender, string address)
        {
            this.name = name;
            this.gender = gender;
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


        public string Address
        {
            get { return address; }
            set { address = value; }
        }

       

        // Accept method to accept data from console
        public void Accept()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter gender (true for male, false for female): ");
            gender = bool.Parse(Console.ReadLine());

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
            return $"Name: {name}, Gender: {genderStr}, Address: {address}";
        }
    }

    public class Employee : Person
    {
        private static int count = 0;
        private int id;
        private double salary;
        private string designation;
        public enum DepartmentType { HR, IT, Sales, Marketing }
        private DepartmentType dept;

        // Default constructor
        public Employee() : base()
        {
            id = ++count;
            salary = 0.0;
            designation = "Unknown";
            dept = DepartmentType.IT;
        }

        // Parameterized constructor
        public Employee(string name, bool gender, string address, double salary, string designation, DepartmentType dept)
            : base(name, gender, address)
        {
            id = ++count;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }

        // Properties
        public int Id
        {
            get { return id; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        // Accept method to accept data from console
        public new void Accept()
        {
            base.Accept();

            Console.Write("Enter salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.Write("Enter designation: ");
            designation = Console.ReadLine();

            Console.Write("Enter department (HR, IT, Sales, Marketing): ");
            string deptInput = Console.ReadLine();
            dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), deptInput, true);
        }

        // Print method to print data to console
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"ID: {id}, Salary: {salary}, Designation: {designation}, Department: {dept}");
        }

        // ToString method to return data of object in string format
        public override string ToString()
        {
            return base.ToString() + $", ID: {id}, Salary: {salary}, Designation: {designation}, Department: {dept}";
        }
    }

    // Example usage
    public class Program
    {
        public static void Main()
        {
            Employee emp1 = new Employee();
            emp1.Accept();
            emp1.Print();

            Employee emp2 = new Employee();
            emp2.Accept();
            emp2.Print();
        }
    }

}
