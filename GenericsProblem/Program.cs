using System;
namespace GenericsProblem
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Generics Problem");
            Console.WriteLine("Enter Which type of Data Type has been Used\n1.int\n2.Float\n3.String");
            int input = Convert.ToInt32(Console.ReadLine());
            int length;
            switch (input)
            {
                case 1:
                    Operation<int> operation = new Operation<int>();
                    Console.WriteLine("Enter the length of the array");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Elements of the Array");
                    int[] array = new int[length];
                    for (int i = 0; i < length; i++)
                    {
                         array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    operation.FindMax(array,length);
                    break;
                case 2:
                    Operation<float> operation1 = new Operation<float>();
                    Console.WriteLine("Enter the length of the array");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Elements of the Array");
                    float[] array1 = new float[length];
                    for (int i = 0; i < length; i++)
                    {
                        array1[i] = Convert.ToSingle(Console.ReadLine());
                    }
                    operation1.FindMax(array1, length);
                    break;
                case 3:
                    Operation<string> operation2 = new Operation<string>();
                    Console.WriteLine("Enter the length of the array");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Elements of the Array");
                    string[] array2 = new string[length];
                    for (int i = 0; i < length; i++)
                    {
                        array2[i] = Console.ReadLine();
                    }
                    operation2.FindMax(array2, length);
                    break;
        }
        }
    }
}