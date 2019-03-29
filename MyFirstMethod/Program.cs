using System;

namespace MyFirstMethod
{
    class Program
    {
   
        /// <summary>
        /// Count to n.
        /// </summary>
        /// <param name="n">Max number</param>
        /// <returns>Int count from 1 to n</returns>
        static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }


        static void CountToN(int n, int o)
        {
            if (n < o)
            {
            for(int i = n; i <= o; i++)
            {
                Console.WriteLine(i);
            }
            }

            if (n > o)
            {
                for(int i = o; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine(n);
        }
        
        /// <summary>
        /// Count to 10.
        /// </summary>
        /// <returns></returns>
        
        static void CountTo10()
        {
            
            CountToN(10);

        }
        
        static void Main(string[] args)
        {
         
            CountToN(2);
            CountToN(2,4);
            CountToN(8);
            CountTo10();
        }
    }
}