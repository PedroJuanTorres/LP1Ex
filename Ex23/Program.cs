using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for operators and numbers
            string operand;
            double numOne;
            double numTwo;

            // If the user insert +/- than 3 arguments
            if (args.Length != 3)
            {
              Console.WriteLine("Error! You must insert 3 arguments");
              return;
            }

            // Conversion of types
            operand = args[0];
            numOne = Convert.ToDouble(args[1]);
            numTwo = Convert.ToDouble(args[2]);

            // If the user don't insert the right operators
            if (operand != "+" && operand != "-" && operand != "*" && operand
                != "/" && operand != "p")  
            {
                Console.WriteLine($@"Error! The caracther ""{operand}"" is invalid!"
                    + $" Unknown operation, program will close.");
                return;
            }

            // Switch loop for each operation
            switch (operand)
            {
                case "+":
                    double sum = numOne + numTwo;
                    Console.WriteLine($"{numOne} + {numTwo} " +
                        $"= {sum}");
                    break;

                case "-":
                    double minus = numOne - numTwo;
                    Console.WriteLine($"{numOne} - {numTwo} " +
                        $"= {minus}");
                    break;

                case "*":
                    double mult = numOne * numTwo;
                    Console.WriteLine($"{numOne} * {numTwo} " +
                        $"= {mult}");
                    break;

                case "/":
                    double div = numOne / numTwo;
                    Console.WriteLine($"{numOne} / {numTwo} " +
                        $"= {div}");
                    break;

                case "p":
                    double poten = Math.Pow(numOne, numTwo);
                    Console.WriteLine($"{numOne} ^ {numTwo} " +
                        $"= {poten}");
                    break;
            }
        }
    }
}
