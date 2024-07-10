using System;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            do
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                int result;

                Console.WriteLine("Enter num1");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter num2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                if(choice == 1)
                {
                    result = num1 + num2;
                    Console.WriteLine(result);
                }
                else if (choice == 2)
                {
                    result = num1 - num2;
                    Console.WriteLine(result);
                }
                else if (choice == 3)
                {
                    result = num1 * num2;
                    Console.WriteLine(result);
                }
                else if (choice == 4)
                {
                    result = num1 / num2;
                    Console.WriteLine(result);
                }

                Console.WriteLine("Do you want to perform another calculation? (Y/N)");


            } while (Console.ReadLine() == "Y");
        }
    }
}
