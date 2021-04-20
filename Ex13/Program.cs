using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            double num1;
            double num2;
            double result;

            Console.WriteLine("Write your first real number:");
            str1 = Console.ReadLine();
            num1 = Convert.ToDouble(str1);
            Console.WriteLine("Write your second real number:");
            str2 = Console.ReadLine();
            num2 = Convert.ToDouble(str2);
            result = Math.Pow(num1,num2);
            Console.WriteLine($"{str1} elevated to the power of {str2} is: {result}");
        }
    }
}
