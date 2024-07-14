using EmployeeLibSharedAssembly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
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

            string fileName = @"C:\Users\sunbeam\Desktop\Dac Assignments\Dotnet_Assignments\Assignment6\myfile.txt";
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            Company deserialedCompanyObj = new Company();


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

                        if (File.Exists(fileName))
                        {
                            fs = new FileStream(fileName, FileMode.Open, FileAccess.Write);


                        }
                        else
                        {
                            fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                        }


                        bf.Serialize(fs, company);


                        fs.Close();



                        break;
                    case 7:

                        if (File.Exists(fileName))
                        {
                            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                            deserialedCompanyObj = (Company)bf.Deserialize(fs);


                            Console.WriteLine("Details of deSerialised objed are shown below");
                            deserialedCompanyObj.Print();


                            fs.Close();


                        }


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

