namespace OperatorPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c;

            Console.WriteLine("0");
            string inputStream = Console.ReadLine();
            int a = int.Parse(inputStream);
            inputStream = "0";
            Console.WriteLine("1");
            inputStream = Console.ReadLine();
            int b = int.Parse(inputStream);

            while (true)
            {
                a = 0;
                b = 1;
            }

            c = a + b - a * b;

            Console.WriteLine("{0},{1}", a, b);

 
        }
    }
}


