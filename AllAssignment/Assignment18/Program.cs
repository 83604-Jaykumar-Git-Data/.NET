namespace Assignment18
{

    public delegate void ptr(int x, int y);
    internal class Program
    {

        public static int Menu()
        {
            Console.WriteLine("0. Exist");
            Console.WriteLine("1. Call all the methods via unicast delegate of MathsStatic class");
            Console.WriteLine("2. Call all the methods via multicast delegateof MathsStatic class");
            Console.WriteLine("3. Call all the  methods via unicast delegate of MathsInstance class");
            Console.WriteLine("4. Call all the  methods via multicast delegate of MathsInstance class");
            Console.WriteLine(" Enter your choice:");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int ch = 0;
            Console.WriteLine("Enter two no's");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            MathsInstance.MathsInstance m = new MathsInstance.MathsInstance();


            ptr staticsumptr = new ptr(MathsStatic.MathsStatic.Sum);
            ptr staticsubptr = new ptr(MathsStatic.MathsStatic.Subtract);
            ptr staticmulptr = new ptr(MathsStatic.MathsStatic.Multiply);
            ptr staticdivptr = new ptr(MathsStatic.MathsStatic.Divide);

            ptr instancesumptr = new ptr(m.Sum);
            ptr instancesubptr = new ptr(m.Subtract);
            ptr instancemulptr = new ptr(m.Multiply);
            ptr instancedivptr = new ptr(m.Divide);


            ptr staticmulticastptr = new ptr(MathsStatic.MathsStatic.Sum);
            staticmulticastptr += MathsStatic.MathsStatic.Subtract;
            staticmulticastptr += MathsStatic.MathsStatic.Multiply;
            staticmulticastptr += MathsStatic.MathsStatic.Divide;



            ptr instancemulticastptr = new ptr(m.Sum);
            instancemulticastptr += m.Subtract;
            instancemulticastptr += m.Multiply;
            instancemulticastptr += m.Divide;



            while ((ch = Menu()) != 0)
            {
                switch (ch)
                {
                    case 1:
                        staticsumptr(x, y);
                        staticsubptr(x, y);
                        staticmulptr(x, y);
                        staticdivptr(x, y);


                        break;
                    case 2:
                        staticmulticastptr(x, y);

                        break;
                    case 3:
                        instancesumptr(x, y);
                        instancesubptr(x, y);
                        instancemulptr(x, y);
                        instancedivptr(x, y);



                        break;
                    case 4:
                        instancemulticastptr(x, y);
                        break;
                    default:
                        Console.WriteLine("Wrong choice!!");
                        break;

                }

            }

            Console.WriteLine("Thankyou for using our Application:)");


        }
    }




}
