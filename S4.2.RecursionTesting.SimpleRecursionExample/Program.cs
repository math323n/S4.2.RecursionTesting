using System;

namespace S4._2.RecursionTesting.SimpleRecursionExample
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(SimpleRecursion(3)); 
        }

       static int SimpleRecursion(int n)
        {
            if(n == 0)  // Base case
                return -1;
            else        // Recursive case
                return SimpleRecursion(n - 1);
        }
    }
}