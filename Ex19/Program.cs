using System;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1,str2;
            double highScore, newScore;

            Console.WriteLine("Write the High score:");
            str1 = Console.ReadLine();
            highScore = Convert.ToDouble(str1);
            Console.WriteLine("Write the new score:");
            str2 = Console.ReadLine();
            newScore = Convert.ToDouble(str2);

            Console.WriteLine(newScore > highScore ? "New high score! " : "Keep trying");
        }
    }
}
