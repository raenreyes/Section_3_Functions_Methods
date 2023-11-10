

using System;

namespace Functions_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny {0}",!isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); //you can increment inside of a statement,
            //the increment only takes effect from the next time num is called
            Console.WriteLine("num is {0}", num);
            //this is how we can have the increment happen before num is called
            Console.WriteLine("num is {0}", ++num);

            //decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--); //you can increment inside of a statement,
            //the increment only takes effect from the next time num is called
            Console.WriteLine("num is {0}", num);
            //this is how we can have the increment happen before num is called
            Console.WriteLine("num is {0}", --num);

            //Addition and subraction operators
            int result;
            result = num1 + num2;
            Console.WriteLine("Result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("Result of num1 - num2 is {0}", result);

            //Multiplying and Dividing operators
            result = num1 * num2;
            Console.WriteLine("Result of num1 * num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Result of num1 / num2 is {0}", result);

            //modulo operator
            result = num1 % num2;
            Console.WriteLine("Result of num1 % num2 is {0}", result);

            //relational and type operators
            bool isLower = num1 < num2;
            Console.WriteLine("Result of num1 < num2 is {0}", isLower);

            //equality operator
            bool isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 is {0}", isEqual);

            //inequality operator
            bool notEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is {0}", notEqual);

            //conditional operators
            bool isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Is it lower and sunny {0}", isLowerAndSunny);
            bool isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("Is it lower or sunny {0}", isLowerOrSunny);
        }


    }
}