using EmployeeLib;
namespace Assignment14;

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
