namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                String fname;
                String lname;
                int age;

                Console.Write("Enter your first name: ");
                fname = Convert.ToString(Console.ReadLine());

                Console.Write("Enter your last name: ");
                lname = Convert.ToString(Console.ReadLine());

                Console.Write("How old are you? : ");
                age = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("First Name: " + fname);
                Console.WriteLine("Last Name: " + lname);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("*****************");
                Console.WriteLine("Age Description");

            if (age >= 50)
            {
            Console.WriteLine("You are a senior");
            }
            else if (age >= 40)
            {
                Console.WriteLine("You are almost at middle age");
            }
            else if (age >= 30)
            {
                Console.WriteLine("You probably have kids");
            }
            else if (age >= 20)
            {
                Console.WriteLine("You are probably working student or sophomore college student");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are young");
            }

            Console.Beep();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
}
    }
}
