using System;

namespace Hamcucbo
{
    class Program
    {
        static void Main(string[] args)
        {
            ListedPrimeNumbers
        }
        static void ListedPrimeNumbers(int from, int to)
        {
            bool IsPrime(int number) // hàm cục bộ      
            {
                if (number < 2)
                {
                    return false;
                }
                int bound = (int)Math.Sqrt(number);
                for (int i = 2; i <= bound; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            for (int i = from; i <= to; i++)
            {
                if (IsPrime(i)) // call to local function        
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
