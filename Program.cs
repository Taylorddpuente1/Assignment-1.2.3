using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, result = 0;
        string operation;
        bool continueCalculating = true;


            Console.WriteLine("Calculator program");

            while (continueCalculating)
            {

                // Get user imput for numbers
                Console.Write("Enter number 1: ");

                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                //Display the operation options

                Console.WriteLine("Enter an Option: ");
                Console.WriteLine(" + : Add");
                Console.WriteLine(" * : Multiply");


                //Get the operation input
                operation = Console.ReadLine();

                //Perform calculation based on the selected operation
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected");
                        continue;
                }

                //Display the result 
                Console.WriteLine($"Result: {num1} {operation} {num2}= {result}");

                //Ask if user wants to perform another calculation
                Console.WriteLine(" Do you want to perform another calculation? (y/n): ");
                string continueChoice = Console.ReadLine().ToLower();


                if (continueChoice != "y")
                {
                    continueCalculating = false;
                    Console.WriteLine("Exiting the program.");
                }

            }


               
        }
    }
}




        