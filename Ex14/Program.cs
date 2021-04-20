using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_lenght;
            string str_height;
            string str_width;
            double lenght;
            double height;
            double width;
            double result;

            Console.WriteLine("Write the lenght:");
            str_lenght = Console.ReadLine();
            lenght = Convert.ToDouble(str_lenght);
            Console.WriteLine("Write the height:");
            str_height = Console.ReadLine();
            height = Convert.ToDouble(str_height);
            Console.WriteLine("Write width:");
            str_width = Console.ReadLine();
            width = Convert.ToDouble(str_width);

            result = lenght * width * height;

            Console.WriteLine($"The result is: {result}");
        }
    }
}
