using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Length property provides the number of array element
            System.Console.WriteLine("parameter count = {0}", args.Length);

            for (int i = 0; i < args.Length; i++)
            {
	            System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
        }
    }
}
