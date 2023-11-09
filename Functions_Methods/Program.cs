

namespace Functions_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AddCount("hey there !HEY THERE !");
        }

        public static void AddCount(string letter)
        {
            int counter = 0;
           for (int i = 0; i < letter.Length; i++)
            {
                counter++;
            }
           Console.WriteLine(counter);
        }
        public static string LowUpper (string text)
        {   
            string low = text.ToLower ();
            string high = text.ToUpper ();
            return low + high;
        }
       
    }
}