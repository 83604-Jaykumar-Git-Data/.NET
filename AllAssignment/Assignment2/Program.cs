using System.Diagnostics;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,result,num1,num2;

            while (true)
            {
                Console.WriteLine("enter first number");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter second number");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("select the operation " +
                    "1.Addition 2.Subtraction 3.Multiplication 4.Division");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine(result);
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine(result);
                        break;

                    case 4:
                        result = num1 / num2;
                        Console.WriteLine(result);
                        break;

                    default:
                        Console.WriteLine("select correct option");
                        break;
                }

                Console.WriteLine("Do you want to continue Y/N??");
                String choice = Console.ReadLine();
                if (choice != "Y"   )
                {
                    break;
                }
            }
            Console.WriteLine("Hit Enter to Close app");
            Console.ReadLine();

        }

        
    }
}
