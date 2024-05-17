using System.Collections.Generic;

namespace solution___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            int fibonacci = 0;
            int i = 1;
            int a = 1;
            int result = 0;
            while (true)
            {
                if (fibonacci < 4000000)
                {
                    if (a % 2 == 0)
                    {
                        result += a;
                    }
                    
                    fibonacci = i + a;
                    i = a;
                    a = fibonacci;


                }
                else
                {
                    Console.WriteLine(result);
                    break;
                }


            }


        }
    }
}