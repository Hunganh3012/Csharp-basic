using System;
using System.ComponentModel.Design;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            isFindNumber(3, 10, 2);
        }

        static void isFindNumber(int a, int b ,int k)
        {
            for(int i = a; i<= b; i++)
            {
                if( i%k ==0)
                {
                    Console.WriteLine(i + " ");
                }

            }
            Console.WriteLine();
        }
    }
}