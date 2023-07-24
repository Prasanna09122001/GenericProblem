using System;
namespace GenericsProblem
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Generics Problem");
            Operation<int> operation = new Operation<int>();
            operation.FindMax(7,8,3);
            Operation<float> operation1 = new Operation<float>();
            operation1.FindMax(1.8f, 1.6f, 1.9f);
            Operation<string> operation2 = new Operation<string>();
            operation2.FindMax("S", "b", "c");

        }
    }
}