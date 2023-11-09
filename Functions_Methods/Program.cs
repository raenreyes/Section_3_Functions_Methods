

namespace Functions_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(AddNumbers());

        }
        public static int AddNumbers ()
        {
            Console.WriteLine("Please enter your first number you would like to add: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Please enter your second number you would like to add: ");
            string input2 = Console.ReadLine();
            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);
            
            int result = number1 + number2;
            return result;

  
        }
    }
}