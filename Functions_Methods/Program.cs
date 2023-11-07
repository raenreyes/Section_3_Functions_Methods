namespace Functions_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am a argument and called from a method");
        }
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
           
        }
        public static void WriteSomethingSpecific(string myText) 
        {
            Console.WriteLine(myText);
        }
    }
}