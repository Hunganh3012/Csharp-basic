﻿using System;

namespace bai1Csharp
{
    class Info
    {
        string name;
        int age;
        public void Xuatscreen()
        {
            Console.WriteLine("Tên:" + name + "Tuổi:" + age);
        }
        //Kiểu tham trị
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
        // Kiểu tham chiếu
        class Student
        {
        public string StudentName { set; get; }
        }




        public static void Main(string[] args)
        {
            //Info Khoi = new Info();
            //Khoi.name = "Hung Anh";
            //Khoi.age = 22;
            //Khoi.Xuatscreen();

            //Bài 1:---- Các kiểu dữ liệu
            //float pi = 3.145F;
            //double pii = 3.145;
            //string name = "Hung Anh";
            //decimal checkDecimal = 1.22222M;
            //char gmail = '@';
            //bool isGPSEnabled = true;

            //Bài 2: Thực hành Kiểu số
            // Tính tổng 2 số;

            //int number1 = 20;
            //int number2 = 30;
            //int sum = number1 + number2;
            //Console.WriteLine("Sum" + sum);

            //Bài 3 : Kiểu String;

            //string myName = "Hung Anh";
            //string[] myNames = myName.Split("");
            //foreach(var word in myNames)
            //{
            //    Console.WriteLine($"{ word}");
            //}
            //Console.WriteLine(myName);
            //Console.Read();


            //Bài4:Kiểu dữ liệu tham trị, và kiểu tham chiếu:
            // Kieu tham trị;
            // int i = 100;
            //Console.WriteLine(i);
            //ChangeValue(i); //nếu k có hàm này hàm ChangeValue k hoạt động nha. Lúc này hàm ChangeValue mới đc kích hoạt vì nó được gọi trong hàm Main
            //Console.WriteLine(i);
            //Result: 100 200 100

            // Kiểu tham chiếu
            //static void ChangeReferenceType(Student std2)
            //{
            //    std2.StudentName = "Steve";

            //}
            //Student std1 = new Student();
            //std1.StudentName = "Bill";
            //Console.WriteLine(std1.StudentName); //Bill
            //ChangeReferenceType(std1);
            //Console.WriteLine(std1.StudentName); //Steve


            //Chuyển đổi kiểu dữ liệu.
            //Chuyển đổi ngầm định tự động.

            //int myInt = 9;
            //double myDouble = myInt;
            //Console.WriteLine(myDouble);

            // Chuyển đổi tường minh bằng tay

            //int five = 5;
            //var doubleFive = (double)five;
            //char a = 'a';
            //var valueA = (int)a;
            //float myfloat = 1.543F;
            //decimal myMoney = (decimal)myfloat;
            //Console.WriteLine(myMoney);


            //chuyển đổi kiểu Conversion.
            //vd1:
            //int four = 4;
            //decimal FourDecimal = Convert.ToDecimal(four);
            //Console.WriteLine(FourDecimal);

            //vd2:
            //decimal myMoney = 4.51M;
            //int intMoney = Convert.ToInt32(myMoney);
            //Console.WriteLine(intMoney);



            //Chuyển đổi kiểu parsing.
            //vd1:
            //           string testString ="10.22.2000"
            //;
            //           double decValue = double.Parse(testString);
            //           Console.WriteLine(decValue);




            //Bài 17:Câu lệnh if else;
            // Cách 1:
            //Console.Write("Nhập 1 số nguyên bất kì:");
            //int number = int.Parse(Console.ReadLine());
            //if (number %2 == 0)
            //{
            //    Console.WriteLine(number + " la so chan");
            //}
            //else
            //{
            //    Console.WriteLine(number + " la so lẻ");
            //}

            //Bài2: Nhập vào giá sản phẩm

            //Console.Write("Nhap gia san pham:");
            //double price = double.Parse(Console.ReadLine());
            //Console.WriteLine("Đa bao gom Vat chua (yes/no):");
            //var answer = Console.ReadLine();
            //bool Vat = answer == "yes" ? true : false;
            //if (Vat) 
            //{
            //    price = (price * 0.1) + price ;

            //}
            //Console.WriteLine("Gia sao thue la :" + price);
        }
    }
}