using System;

namespace Doiso
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = "Hoang";
            var last = "Ngo";
            var age = 20;
            var gpa = 3.56f;
            Name(fullname: first, lastname: last, gpa: gpa, age: age);
        }
        static void Name(string fullname, string lastname,int age, float gpa)
        {
            Console.WriteLine($"Fullname:{fullname}");
            Console.WriteLine($"Lastname:{lastname}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Gpa:{gpa}");
        }
    }
}
