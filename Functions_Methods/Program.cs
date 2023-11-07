namespace Functions_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(Add(15,31));
            Console.WriteLine(Mulitply(4,6));
        }
        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
        public static int Mulitply(int param1, int param2)
        {
            return param1 * param2;
        }
    }
}