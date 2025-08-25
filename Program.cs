namespace secondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = Convert.ToInt32(x);
            Console.WriteLine(y.GetType());

            double c = 3.14;
            double d = Convert.ToDouble(c);
            Console.WriteLine(d.GetType());

            String name = "John Doe";
            String user = Convert.ToString(name);
            Console.WriteLine(user);

            String g = "#";
            char h = Convert.ToChar(g);
            Console.WriteLine(h.GetType());

            String m = "false";
            bool n = Convert.ToBoolean(m);
            Console.WriteLine(n.GetType());
            Console.Beep();

            String s = "true";
            bool t = Convert.ToBoolean(s);
            Console.WriteLine(t.GetType());
        }
    }
}
