using System;
using System.Diagnostics;

namespace S4._2.RecursionTesting.SimpleRecursionExample
{
    class Program
    {
        static void Main()
        {
            //SimpleRecursion(3);
            //FibonacciSequence();

            //for(int n = 1; n <= 14; n++)
            //{
            //    Console.WriteLine(FactorialRecursion(n));
            //}
            //Console.ReadLine();
            try
            {
                throw new Exception("This is the exception",
         new Exception("This is the first inner exception.",
             new Exception("This is the last inner exception.")));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ExceptionTesting.ExceptionTesting.GetInnerExceptions(ex).Message);
            }
        }
        


        private static int SimpleRecursion(int n)
        {
            if(n == 0)  // Base case
                return -1;
            else        // Recursive case
                return SimpleRecursion(n - 1);
        }

        private static void FibonacciSequence()
        {
            for(int n = 2; n < 1001; n++)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                int result = Fibonacci(n);
                timer.Stop();
                Console.WriteLine($"{n}, {result} Elapsed time: {timer.Elapsed}");
                timer.Reset();
            }
            Console.ReadLine();
        }


        private static int Fibonacci(int n)
        {
            if(n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static int FactorialRecursion(int number)
        {
            if(number == 1)
                return 1;
            else
                return number * FactorialRecursion(number - 1);
        }

    }
}