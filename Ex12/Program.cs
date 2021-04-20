using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            int num1;
            int num2;

            Console.WriteLine("Write your first integer number:");
            str1 = Console.ReadLine();
            num1 = Convert.ToInt32(str1);
            Console.WriteLine("Write your second integer number:");
            str2 = Console.ReadLine();
            num2 = Convert.ToInt32(str2);
            Console.WriteLine($"The sum of both number is: {num1+num2}");
        }
    }
}
