using System.Runtime;

namespace RandomMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();

            //int x = random.Next(1,10);

            //Console.WriteLine("Shuffle number (1-10)");
            //Console.WriteLine(x);

            //double y = random.NextDouble();

            //Console.WriteLine("Shuffle decimal number (0.0, 1.0)");
            //Console.WriteLine(y);

            Random user = new Random();

            int roll1;
            int roll2;
            int roll3;

            Console.WriteLine("Rolling Three Dice");
            Console.WriteLine("First Dice");
            Console.Write("Enter any number to roll: ");  // Your input will act like you are shaking your hands before you roll a dice.
            roll1 = Convert.ToInt32(Console.ReadLine());
            roll1 = user.Next(1, 8);

            Console.WriteLine("Second Dice");
            Console.Write("Enter any number to roll: ");
            roll2 = Convert.ToInt32(Console.ReadLine());
            roll2 = user.Next(1, 8);

            Console.WriteLine("Third Dice");
            Console.Write("Enter any number to roll: ");
            roll3 = Convert.ToInt32(Console.ReadLine());
            roll3 = user.Next(1,8);

            Console.WriteLine("First Dice: " + roll1);
            Console.WriteLine("Second Dice: " + roll2);
            Console.WriteLine("Third DIce: " + roll3);
        }
    }
}
