namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String choice;
            double fnumber;
            double snumber;
            String exit;
            bool isRunning = true;

            while (isRunning)
            {

                Console.WriteLine("****************");
                Console.WriteLine("Calculator");
                Console.WriteLine("****************");

                Console.WriteLine("First Number: ");
                fnumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Second Number: ");
                snumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("+, - ,* ,/");
                Console.WriteLine("type exit to stop the program");
                Console.Write("Choose operators on display: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "+":
                        Console.WriteLine("Additional total: " + (fnumber + snumber));
                        break;

                    case "-":
                        Console.WriteLine("Subtraction total: " + (fnumber - snumber));
                        break;
                    case "*":
                        Console.WriteLine("Multiplication total: " + (fnumber * snumber));
                        break;
                    case "/":
                        if (snumber == 0)
                        {
                            Console.WriteLine("Cannot divided by zero");
                            break;
                        }
                        Console.WriteLine("Division total: " + (fnumber / snumber));
                        break;
                    case "exit":
                        isRunning = false;  
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                     
                }
            }
            Console.ReadKey();
        }
    }
}
