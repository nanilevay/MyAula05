using System;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int n)
        {
            // verificar a posicao pedida pelo user
            int number;

            // se for 1 ou 2, a resposta eh 1
            if (n <= 2)
                number = 1;

            // se for mais, a resposta eh a soma dos 2 ultimos numeros
            else
                number = Fibonacci(n - 2) + Fibonacci(n - 1);

            return number;
        }

        static void Main(string[] args)
        {
            // declaracao de variaveis
            string answer;
            int aux;
            int fib;

            // obter input, transformar a inteiro e invocar o metodo
            Console.WriteLine("choose a number within the sequence");
            answer = Console.ReadLine();
            aux = Convert.ToInt32(answer);
            fib = Fibonacci(aux);

            // imprimir numero correspondente a posicao pedida
            Console.WriteLine(fib);

        }
    }
}
