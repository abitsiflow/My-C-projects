namespace secondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int friends = 4;
            Console.WriteLine("Friends remaining: " + friends);
            friends--;
            Console.WriteLine("Friend unfriend you ");
            Console.WriteLine("Friends remaining: " + friends);

            Console.WriteLine("you have a new friend");
            friends++;
            Console.WriteLine("Friends remaining: " + friends);

            Console.WriteLine("You have new 2 friends");
            friends += 2;
            Console.WriteLine("Friends remaining: " + friends);

            Console.WriteLine("Friends divisible by 2");
            friends = friends / 2;
            Console.WriteLine("Friends remaining: " + friends);

            Console.WriteLine("Friends multiply by 4");
            friends = friends * 4;
            Console.WriteLine("Friends remaining: " + friends);

            Console.WriteLine("Number of friends if it's odd or even");
            bool v = friends % 2 == 0;
            Console.WriteLine(friends);
        }   
    }
}
