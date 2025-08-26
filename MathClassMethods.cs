using System.Xml.Schema;

namespace mathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fnumber;
            double snumber;
            double total;

            Console.WriteLine("**************");
            Console.WriteLine("Math pow Calculator");
            Console.WriteLine("**************");

            Console.Write("Enter first number: ");
            fnumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            snumber = Convert.ToDouble(Console.ReadLine());

            total = Math.Pow(fnumber, snumber);
            Console.WriteLine("Total with the power of the second number: " + total) ;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***********************");
            Console.WriteLine("Square Root Calculator");
            Console.WriteLine("***********************");

            double numOfSqrt;

            Console.WriteLine("Enter a number you want to square root: ");
            numOfSqrt = Convert.ToDouble(Console.ReadLine());

            numOfSqrt = Math.Sqrt(numOfSqrt);
            Console.WriteLine("Square root: " + numOfSqrt);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**********************");
            Console.WriteLine("Math abs Calculator ");
            Console.WriteLine("**********************");

            double numOfAbs;

            Console.WriteLine("Enter a number you want to abs: ");
            numOfAbs = Convert.ToDouble(Console.ReadLine());
            numOfAbs = Math.Abs(numOfAbs);

            Console.WriteLine("Output: " + numOfAbs);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*********************");
            Console.WriteLine("Math Round Calculator");
            Console.WriteLine("*********************");

            double numOfRound;

            Console.WriteLine("Enter a number of you want to round: ");
            Console.WriteLine("Note: your input must have decimal point");
            numOfRound = Convert.ToDouble(Console.ReadLine());
            numOfRound = Math.Round(numOfRound);
            Console.WriteLine("Round number: " + numOfRound);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("*********************");
            Console.WriteLine("Math Ceiling Calculator");
            Console.WriteLine("*********************");

            double numOfCeiling;

            Console.WriteLine("Enter a number of you want to round: ");
            Console.WriteLine("Note: your input must have decimal point");
            numOfCeiling = Convert.ToDouble(Console.ReadLine());
            numOfCeiling = Math.Ceiling(numOfCeiling);
            Console.WriteLine("Ceiling total: " + numOfCeiling);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************************");
            Console.WriteLine("Math Floor");
            Console.WriteLine("****************************");

            double numOfFloor;

            Console.WriteLine("Enter a number you want to know its floor:");
            Console.WriteLine("Note: your input must have decimal point");
            numOfFloor = Convert.ToDouble(Console.ReadLine());
            numOfFloor = Math.Floor(numOfFloor);
            Console.WriteLine("Floor value: " + numOfFloor);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*********************");
            Console.WriteLine("Math Max");
            Console.WriteLine("*********************");

            double fnumOfMax;
            double snumOfMax;
            double totalOfMax;

            Console.WriteLine("Enter a number you want to know its Max:");
            Console.WriteLine("Note: your input must have decimal point");
            fnumOfMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number you want to know its Max:");
            Console.WriteLine("Note: your input must have decimal point");
            snumOfMax = Convert.ToDouble(Console.ReadLine());
            totalOfMax = Math.Max(fnumOfMax, snumOfMax);

            Console.WriteLine("Max output: " + totalOfMax);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*********************");
            Console.WriteLine("Math min");
            Console.WriteLine("*********************");

            double fnumberOfMin;
            double snumberOfMin;
            double totalOfMin;

            Console.WriteLine("Enter a first number for min: "); 
            fnumberOfMin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number for min: ");
            snumberOfMin = Convert.ToDouble(Console.ReadLine());

            totalOfMin = Math.Min(fnumberOfMin, snumberOfMin);

            Console.WriteLine("Min Total: " + totalOfMin);
        }
    }
}
