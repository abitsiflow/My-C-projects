namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            String fname = "John";
            String lname = "Doe";

            Console.Write("HELLO NEIGHBORHOOD!!!!!!!!!!");
            Console.Write("");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("I am " + fname + " " + lname);
            Console.WriteLine("I am " + age + " years old!");
            Console.Beep();

            //this is a comment
            /*
             * This is a multi line comment
             * 
             * 
             */

            Console.WriteLine("Hello \n \bWorld!!");

            Console.ReadKey();// this method preventing to end the program until the user enter a key to end the program
        }
    }
}
