namespace Functions_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Billy";
            string friend3 = "Raen";

            Console.WriteLine(GreetFriend(friend1));
            Console.WriteLine(GreetFriend(friend2));
            Console.WriteLine(GreetFriend(friend3));
        }
        public static string GreetFriend(string friend)
        {
            return "Hello " + friend;
        }
    }
}