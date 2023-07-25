using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class Operation<T> where T :IComparable
    {
        public void FindMax (T[] arr,int length)
        {
            Array.Sort(arr);
            Console.WriteLine(arr[length-1]+" is the Maximum Element");
        }
    }
}
