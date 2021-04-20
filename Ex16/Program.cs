using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1,str2,str3;
            int num1,num2,num3;

            Console.WriteLine("Write your first number");
            str1 = Console.ReadLine();
            num1 = Convert.ToInt32(str1);
            Console.WriteLine("Write your second number");
            str2 = Console.ReadLine();
            num2 = Convert.ToInt32(str2);
            Console.WriteLine("Write your third number");
            str3 = Console.ReadLine();
            num3 = Convert.ToInt32(str3);

            if(num1+num2==num3 || num1 + num3 == num2 || num2 + num3 == num1){
                Console.WriteLine("É possível :)");
            }
            else{
                Console.WriteLine("Impossível :(");
            }
        }
    }
}
