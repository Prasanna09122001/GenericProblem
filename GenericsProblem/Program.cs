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
          //  operation.FindMax<float>(1.8f, 1.6f, 1.7f);
          //  operation.FindMax<string>("a", "b", "c");

        }
    }
}