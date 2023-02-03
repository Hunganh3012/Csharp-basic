using System;
using System.ComponentModel.Design;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            //isFindNumber(3, 10, 2);
            int t = int.Parse(Console.ReadLine());
            // lần lượt nhập từng bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                // kiểm tra và đưa ra kết luận n có hoàn hảo không
                if (IsPerfectNumber(n))
                {
                    Console.WriteLine($"Test {i}: YES");
                }
                else
                {
                    Console.WriteLine($"Test {i}: NO");
                }
            }
        }

        static void isFindNumber(int a, int b, int k)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % k == 0)
                {
                    Console.WriteLine(i + " ");
                }

            }
            Console.WriteLine();
        }

        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            // tính tổng ước
            for (int k = 1; k < number; k++)
            {
                if (number % k == 0)
                {
                    sum += k;
                }
            }
            return sum == number;
        }
    }
}