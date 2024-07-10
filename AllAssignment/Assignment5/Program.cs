namespace Assignment5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Date date1 = new Date();
            date1.AcceptDate();
            Date date2 = new Date();
            date2.AcceptDate();

            date1.PrintDate();
            date2.PrintDate();

            if (date1.IsValid() && date2.IsValid())
            {
                Console.WriteLine($"{date1.ToString()} and {date2.ToString()} is a valid date.");
            }
            else
            {
                Console.WriteLine($"{date1.ToString()} is not a valid date.");
            }

            int difference = Date.DifferenceInYears(date1, date2);
            Console.WriteLine($"Difference in years: {difference}");

            difference = date1 - date2;
            Console.WriteLine($"Difference in years using overloaded operator: {difference}");
        }
    }
    }

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
        public bool IsValid()
        {
            if (year < 1 || month < 1 || month > 12 || day < 1)
            {
                return false;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day > daysInMonth[month - 1])
            {
                return false;
            }

            return true;
        }

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
