using System;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int n)
        {
            int number;

            if (n <= 2)
                number = 1;
            else
                number = Fibonacci(n - 2) + Fibonacci(n - 1);

            return number;
        }

        static void Main(string[] args)
        {
            int answer;
         
            Console.WriteLine("choose a number within the sequence");
            answer = Fibonacci(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(answer);

        }
    }
}
