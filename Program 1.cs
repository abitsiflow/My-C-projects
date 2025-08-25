namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

           double a = 3.3232;
            double b = Convert.ToInt32(a);
            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;

            Console.WriteLine(b.GetType());
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
