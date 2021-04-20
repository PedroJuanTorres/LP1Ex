using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
        
            Console.WriteLine("Write the meaning of life:");
            str = Console.ReadLine();
            
            if(str.Length<5){
                Console.WriteLine("That's not very meaningful, is it?");
            }
            else if(str.Length>20){
                Console.WriteLine("Too long to read");
            }
            else{
                Console.WriteLine("Ok, if you say so");
            }
        }
    }
}
