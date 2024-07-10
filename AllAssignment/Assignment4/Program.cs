namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student stud = new Student();
            stud.AcceptDetails();
            stud.PrintDetails();
        }
    }


    struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;
        public Student()
        {
            name = string.Empty;
            gender = false;
            age = 0;
            std = 0;
            div = 'A';
            marks = 0.0;
        }
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Std
        {
            get { return std; }
            set { std = value; }
        }

        public char Div
        {
            get { return div; }
            set { div = value; }
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public void AcceptDetails()
        {
            Console.Write("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender 0.Female 1.Male");
            gender = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter standard: ");
            std = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter division: ");
            div = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter marks: ");
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
