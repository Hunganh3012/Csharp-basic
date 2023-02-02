using System;

namespace caudieukien
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Câu điều kiện 
            Console.WriteLine("----------------Cau dieu kien If else-------------------");
            Console.WriteLine("Nhap 1 so nguyen:");
            int a = int.Parse(Console.ReadLine());
            if( a < 0)
            {
                Console.WriteLine($" {a} la so am");
            }
            else if( a==0)
            {
                Console.WriteLine($" {a} = 0 ");
            }
            else
            {
                Console.WriteLine($"{a} la so duong");
            }

            Console.WriteLine("-------------Cau truc switch--------------- ");
            //Ví dụ xét điểm chữ khi biết điểm gpa ở hệ 4 biết:
            //Đạt điểm A + nếu 4.0 > gpa >= 3.6.
            //Đạt điểm A nếu 3.6 > gpa >= 3.2.
            ////Đạt điểm B nếu 3.2 > gpa >= 2.8.
            //Đạt điểm C nếu 2.8 > gpa >= 2.0.
            //Đạt điểm D nếu 2.0 > gpa >= 1.6.
            //Trượt môn nếu 0.0 <= gpa < 1.6.
            Console.WriteLine(" Nhap diem Gpa:");
            double gpa = float.Parse(Console.ReadLine());
            string rank;
            switch (gpa) 
            {
                case < 1.6 and >= 0.0:
                    rank = "F";
                    break;
                case < 2.0 and >= 1.6:
                    rank = "D";
                    break;
                case < 2.8 and >= 2.0:
                    rank = "C";
                    break;
                case < 3.2 and >= 2.8:
                    rank = "B";
                    break;
                case < 3.6 and >= 3.2:
                    rank = "A";
                    break;
                case < 4.0 and >= 3.6:
                    rank = "A+";
                    break;
                default:
                    rank = "";
                    Console.WriteLine("Wrong Gpq. Please again");
                    break;

            }
            Console.WriteLine($"GPA = {gpa}, rank = {rank}");


            Console.WriteLine("---------------Toán tử 3 ngôi -----------------");
            //Cú pháp: condition? consequent : alternative
            //Xét tính chẵn lẻ của 1 số nguyên n:
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            string results = n % 2 == 0 ? $"{n} la so chan" : $"{n} la so le";
            Console.WriteLine(results);


            Console.WriteLine("---------------Vòng lặp for -----------------");
            //Liệt kê các số chia hết cho k khác 0 trong đoạn[a, b]:
                Console.WriteLine("Nhap a1:");
                float a1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap a1:");
                float a2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so k:");
                float k = float.Parse(Console.ReadLine());
                for( float i =a1; i <= a2; i++)
                {
                    if( i%k ==0)
                {
                    Console.Write(i + " ");
                }
                }

            Console.WriteLine("---------------------Do while-----------");
            //dễ

            Console.WriteLine("---------------------Vòng lặp lòng nhau---------------------");



        }
    }
}