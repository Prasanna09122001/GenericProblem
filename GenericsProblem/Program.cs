using System;
namespace GenericsProblem
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Generics Problem");
            Operation operation = new Operation();
            operation.FindMaxInteger(7, 8, 3);
            operation.FindMaxFloat(1.8f, 1.6f, 1.7f);
            operation.FindMaxString("a", "b", "c");

        }
    }
}