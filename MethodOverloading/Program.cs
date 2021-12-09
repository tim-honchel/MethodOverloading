using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2, 2");
            Console.WriteLine(Add(2, 2));
            Console.WriteLine("");

            Console.WriteLine("3, 2, true");
            Console.WriteLine(Add(3, 2, true));
            Console.WriteLine("");

            Console.WriteLine("0, 1, true");
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine("");

            Console.WriteLine("5, 2, false");
            Console.WriteLine(Add(5, 2, false));
            Console.WriteLine("");

            Console.WriteLine("4.1, 2.3");
            Console.WriteLine(Add(4.1, 2.3));
           
        }
        static string Add(int number1, int number2)
        {
            return $"The sum is {number1 + number2}.";

        }

        static string Add(double number1, double number2)
        {
            return $"The sum is {number1 + number2}.";
        }

        static string Add(int number1, int number2, bool check)
        {
            string plural = number1 + number2 >= 2 ? "s" : "";
            return check == true ? $"The sum is {number1 + number2} dollar{plural}." : $"The sum is {number1 + number2}.";
        }



    }
}
