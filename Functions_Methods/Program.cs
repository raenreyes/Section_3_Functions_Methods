

namespace Functions_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try //you want code to be tried and you dont want your program to crash
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException) //if the code did not work then the catch will execute
            {
                Console.WriteLine("Format exception please enter the correct type next time!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception number was either too small or too large!");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception!");
            } finally //finally happens when the try and catch statement is done. This closes the statmetn which is very important
            {
                Console.WriteLine("This is called anyways");
            }
          
        




        }
       
    }
}