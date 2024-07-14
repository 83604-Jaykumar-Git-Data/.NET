using EmployeeLibSharedAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    internal class Program
    {

        public static int Menu()
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. See details of the company");
            Console.WriteLine("2. Add new employee in the company");
            Console.WriteLine("3. Remove employee from the company");
            Console.WriteLine("4. See all our current Employees");
            Console.WriteLine("5. Find employee by id");
            Console.WriteLine("6. Serialize");
            Console.WriteLine("7. Deserialized");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Enter your choice!");



            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choice;
            Company company = new Company();
            Employee emp = new Employee();
            LinkedListNode<Employee> LinkNodeemp;

            Console.WriteLine("Register existing company to our application");
            company.Accept();

            while ((choice = Menu()) != 0)
            {

                switch (choice)
                {

                    case 1:
                        company.Print();
                        break;
                    case 2:
                        emp.Accept();
                        company.AddEmployee(emp);

                        break;
                    case 3:
                        Console.WriteLine("Enter Employee Id who you want to kick OFF from the company");
                        company.RemoveEmployee(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        company.PrintEmployees();
                        break;
                    case 5:
                        Console.WriteLine("Enter employee id you wish to find");
                        LinkNodeemp = company.FindEmployee(Convert.ToInt32(Console.ReadLine()));
                        if (LinkNodeemp != null)
                        {

                            Employee e = LinkNodeemp.Value;
                            Console.WriteLine($"Employee found: {e}");
                        }
                        else
                        {
                            Console.WriteLine("Employee Id was not found");
                        }
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            }
            Console.WriteLine("Thankyou! for using our application");
        }
    }
}
