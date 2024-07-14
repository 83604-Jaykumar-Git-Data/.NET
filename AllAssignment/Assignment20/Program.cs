using EmpLibrary;
using System.Collections;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment20
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
            Console.WriteLine("6. (SOAP)Serialize");
            Console.WriteLine("7. (SOAP)Deserialized");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Enter your choice!");



            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choice;
            Company company = new Company();
            Employee emp = new Employee();
            Employee e = new Employee();
            //LinkedListNode<Employee> LinkNodeemp;
            ArrayList emps;
            ptr myptr = new ptr(company.CalculateSalaryExpense);
            company.OnEmpListChanged += myptr;

            string fileName = @"C:\Users\sunbeam\Desktop\Dac Assignments\Dotnet_Assignments\Assignment7\myfile.txt";
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            //SoapFormatter sf = new SoapFormatter();

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
                        e = company.FindEmployee(Convert.ToInt32(Console.ReadLine()));
                        if (e != null)
                        {


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
                        //sf.Serialize(fs, company);


                        fs.Close();



                        break;
                    case 7:

                        if (File.Exists(fileName))
                        {
                            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                            deserialedCompanyObj = (Company)bf.Deserialize(fs);
                            //deserialedCompanyObj = (Company)sf.Deserialize(fs);


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
