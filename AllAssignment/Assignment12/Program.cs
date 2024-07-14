using System.Xml.Serialization;

namespace Assignment12;

internal class Program
{
    static int menu()
    {
        Console.WriteLine("0. EXIT");
        Console.WriteLine("1. Add Employee to company: ");
        Console.WriteLine("2. Remove employee by ID: ");
        Console.WriteLine("3. Find employee by ID: ");
        Console.WriteLine("4. Display all employees in company: ");
        Console.WriteLine("5. Display all info about company: ");

        Console.WriteLine("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        return choice;
    }
    static void Main(string[] args)
    {
        int iChoice;
        Employee e = null;
        Company company = new Company();
        while ((iChoice = menu()) != 0)
        {

            switch (iChoice)
            {
                case 0:
                    return;

                case 1:
                    e = new Employee();

                    e.Accept();
                    company.Accept();

                    company.AddEmployee(e);

                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Employee added successfull...");
                    Console.WriteLine("-----------------------------------------------------");
                    break;

                case 2:
                    Console.WriteLine("Enter id to fire employee");
                    int id = Convert.ToInt32(Console.ReadLine());

                    company.RemoveEmployee(id);

                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Employee fired successfull...");
                    Console.WriteLine("-----------------------------------------------------");

                    break;

                case 3:
                    Console.WriteLine("Enter id to find employee");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------------");
                    LinkedListNode<Employee> emp = company.FindEmployee(id1);
                    Console.WriteLine(emp);
                    Console.WriteLine("-----------------------------------------------------");
                    break;

                case 4:
                    Console.WriteLine("-----------------------------------------------------");
                    company.PrintEmployees();
                    Console.WriteLine("-----------------------------------------------------");
                    break;

                case 5:
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine(company);
                    Console.WriteLine("-----------------------------------------------------");
                    break;

                default:
                    Console.WriteLine("OOPS....wrong choice!!!");
                    break;
            }
        }
    }
}

public class Date
{
    private int day;
    private int month;
    private int year;

    public Date()
    {
        day = 1;
        month = 1;
        year = 1;
    }
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }



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

    public void acceptDate()
    {
        Console.WriteLine("Enter day : ");
        day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter month : ");
        month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter year : ");
        year = Convert.ToInt32(Console.ReadLine());
    }

    public void printDate()
    {
        Console.WriteLine("Date : " + day + "/" + month + "/" + year);
    }

    public bool isValid()
    {
        if (year > 1000 && year <= 3000)
        {
            if (day > 0 && day <= 31)
            {
                if (month < 13)
                {
                    if (month % 2 == 1 || month == 8)
                    {
                        if (day >= 0 && day <= 31)
                        {
                            return true;
                        }
                    }
                    else if (month == 2)
                    {
                        if (day >= 0 && day <= 28)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (day > 0 && day <= 30)
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    public static Date operator -(Date date1, Date date2)
    {
        Date d3 = new Date();

        d3.Year = date1.Year - date2.Year;
        d3.Month = date1.Month - date2.Month;
        d3.Day = date1.Day - date2.Day;

        return d3;
    }

    public override string ToString()
    {
        return day + "/" + month + "/" + year;
    }
}


public class Person
{
    private string name;
    private bool gender;
    private Date birth;
    private string address;

    public Person()
    {
        birth = new Date();
    }

    public Person(string name, bool gender, Date birth, string address)
    {
        this.name = name;
        this.gender = gender;
        this.birth = birth;
        this.address = address;
    }



    public String Name
    {
        get { return name; }

    }
    public String Gender
    {
        get { return gender ? "Male" : "Female"; }

    }
    public Date Birth
    {
        get { return birth; }

    }
    public String Address
    {
        get { return address; }

    }



    public void Accept()
    {
        Console.WriteLine("Enter name :");
        name = Console.ReadLine();

        Console.WriteLine("Enter gender :");
        gender = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter address :");
        address = Console.ReadLine();

        birth.acceptDate();

    }
    public override string ToString()
    {
        return " Name: " + Name + " Address: " + Address + " " + " Gender: " + Gender + " " + birth.ToString();
    }

}


public enum DepartmentType
{
    HR = 0,
    FINANCE,
    SALES
};
public class Employee : Person
{
    private int id;

    private double salary;

    private string designation;

    private DepartmentType dept;

    private static int autogenerate = 1;

    public Employee()
    {

        this.id = autogenerate++;
        this.dept = DepartmentType.HR; // default HR department

    }

    public Employee(double salary, string designation, DepartmentType dept)
    {

        this.id = autogenerate++;
        this.salary = salary;
        this.designation = designation;
        this.dept = dept;

    }

    public DepartmentType Dept
    {
        get { return dept; }
        set { dept = value; }
    }

    public string Designation
    {
        get { return designation; }
        set { designation = value; }
    }


    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    public int Id
    {
        get { return id; }
        set { id = value; }
    }


    public void Accept()
    {
        base.Accept();
        Console.WriteLine("Enter salary");
        Salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter designation");
        Designation = Console.ReadLine();
        Console.WriteLine("Choose your department from menu shown below:");

        switch (menu())
        {
            case 1:
                dept = DepartmentType.HR;
                break;
            case 2:
                dept = DepartmentType.FINANCE;
                break;
            case 3:
                dept = DepartmentType.SALES;
                break;

            default:
                Console.WriteLine("WRONG CHOICE SENDING YOU IN HR DEPARTMENT AS PUNISHMENT!");
                break;
        }
    }

    public void Print()
    {
        base.ToString();
        Console.WriteLine("Emp ID: " + Id + ",Salary: " + Salary + "Designation: " + Designation + "DepartmentType: " + Dept);
    }

    public override string ToString()
    {
        return base.ToString() + "Emp ID: " + Id + " ,Salary: " + Salary + ", Designation: " + Designation + " ,DepartmentType: " + Dept;
    }

    int menu()
    {
        Console.WriteLine("1. HR \n 2. Finance\n  3. Sales");
        return Convert.ToInt32(Console.ReadLine());
    }

}


public class Supervisor : Employee
{

    private int subbordinates;

    public Supervisor() : base()
    {



    }

    public Supervisor(int subbordinates, double salary, string designation, DepartmentType dept) : base(salary, designation, dept)
    {
        this.subbordinates = subbordinates;


    }

    public int Subbordinates
    {
        get { return subbordinates; }
        set { subbordinates = value; }
    }

    public void Accept()
    {
        base.Accept();
        Designation = "Supervisor";
        Console.WriteLine("Enter Number of assistants");
        Subbordinates = Convert.ToInt32(Console.ReadLine());


    }

    public void Print()
    {
        base.Print();
        Console.WriteLine(" Number of assistants: " + Subbordinates);
    }

    public override string ToString()
    {
        return base.ToString() + " Number of assistants: " + Subbordinates;
    }


}

public class WageEmp : Employee
{
    private int hrs;
    private int rate;

    public WageEmp()
    {

    }

    public WageEmp(int hrs, int rate)
    {
        this.hrs = hrs;
        this.rate = rate;
    }

    public int Rate
    {
        get { return rate; }
        set { rate = value; }
    }

    public int Hrs
    {
        get { return hrs; }
        set { hrs = value; }
    }

    public void Accept()
    {
        base.Accept();
        base.Designation = "Wage";

        Console.WriteLine("Enter hrs: ");
        Hrs = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter rate: ");
        Rate = Convert.ToInt32(Console.ReadLine());

    }

    public void Print()
    {
        base.Print();
        Console.WriteLine("Hrs is: " + Hrs);
        Console.WriteLine("Rate is: " + Rate);
    }
    public override string ToString()
    {
        return base.ToString() + "Hrs is: " + Hrs + "Rate is: " + Rate;
    }

}


public class Company
{
    private string name;
    private string address;
    private double salaryExpense;
    LinkedList<Employee> empList = new LinkedList<Employee>();


    public Company()
    {

    }
    public Company(string name, string address, double salaryExpense)
    {
        this.name = name;
        this.address = address;
        this.salaryExpense = salaryExpense;
    }
    public double SalaryExpense
    {
        get { return salaryExpense; }
        set { salaryExpense = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private Employee emp;

    public Employee Emp
    {
        get { return emp; }
        set { emp = value; }
    }

    public void Accept()
    {
        Console.WriteLine("Enter your company name: ");
        Name = Console.ReadLine();

        Console.WriteLine("Enter your company address: ");
        Address = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine("Enter your company name: " + Name);
        Console.WriteLine("Enter your company address: " + Address);
    }

    public double CalculateSalaryExpense()
    {
        foreach (Employee emp in empList)
        {
            SalaryExpense = SalaryExpense + emp.Salary;
        }
        return SalaryExpense;
    }

    public void AddEmployee(Employee e)
    {
        empList.AddLast(e);

    }

    public void RemoveEmployee(int id)
    {
        foreach (Employee emp in empList)
        {
            if (emp.Id == id)
            {
                empList.Remove(emp);
            }
        }
    }

    public LinkedListNode<Employee> FindEmployee(int id)
    {
        foreach (Employee emp in empList)
        {
            if (emp.Id == id)
            {
                return empList.Find(Emp);
            }
        }
        return null;

    }

    public override string ToString()
    {
        return "Company name: " + Name + " Address: " + Address + " ,Company Expenses: " + SalaryExpense;
    }

    public void PrintEmployees()
    {
        foreach (Employee emp in empList)
        {
            emp.Print();
        }
    }


}
