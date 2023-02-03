using System;

namespace thamso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----Tham số, tham chiếu-----");
            //Keyword ref: cho phép phương thức được quyền thay đổi giá trị của đối số.
            //Keyword in: cho phép truyền tham chiếu nhưng không cho phép phương thức thay đổi giá trị đối số.
            //Keyword out: cho phép truyền tham chiếu trong đó phương thức được gọi phải gán giá trị mới cho đối số.
            //Tất cả các đối số sử dụng để truyền tham chiếu phải là các biến.



            int[] numbers = { 1, 3, 2, 5, 8, 4, 6, 9, 7 };
             int maxValue =  FindMax(numbers);
     
            Console.WriteLine(maxValue);
            Console.WriteLine("---------------------Đảo số:--------------------");

            //Console.WriteLine("Nhâp a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhâp b:");
            //int b = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.WriteLine($"số {a}");
            Console.WriteLine($"Sô {b}");
        }


        static ref int FindMax(int[] arr)
        {
            int max = arr[0];
            int maxValueIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxValueIndex = i;
                }
            }
            return ref arr[maxValueIndex];
        }
        static void Swap(ref int a, ref int b)
        {
            int thp = a;
            a = b;
            b = thp;
        
        }
        //Tuy nhiên nếu đổi ref thành in ở code trên thì ctrinh sẽ lỗi. vì in k thể thay đổi giá trị.
     
        

    }
}
