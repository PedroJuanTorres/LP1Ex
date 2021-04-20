using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int num;

            Console.WriteLine("Write your number:");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);

            if(num%5==0 && num%3==0){
                Console.WriteLine("FizzBuzz!");
            }
            else if(num%5==0){
                Console.WriteLine("Buzz!");
            }
            else if(num%3==0){
                Console.WriteLine("Fizz!");
            }
            else{
                Console.WriteLine($"{num}!");
            }
        }
    }
}
