using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter with your string");
            string userChoice = Console.ReadLine();
            char[] arr = userChoice.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
