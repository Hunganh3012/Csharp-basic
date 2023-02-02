using System;

namespace Kieudulieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------Ép kiểu Parse--------------
            //Parse sẽ chuyển kiểu chuỗi thành 1 kiểu khác . và nếu không đúng định dạng
            // sẽ trả về thông báo ngoại lệ(exception)
            int a = Int32.Parse("123"); //chuyễn chuỗi 123 thành kiểu số nguyen
            //Console.WriteLine(a);
            //float b = float.Parse("Hunganh");
            //Console.WriteLine(b); // kiểu sai định dạng sẽ bị exception



            //------------------Ép kiểu TryParse---------------
            //Tương tự như Parse nhưng sẽ không xuất ra ngoại lệ. nếu sai định dạng sẽ in ra false hoặc 0
            //float c;
            //float.TryParse("12.7", out c);
            //Console.WriteLine(c);

            //-------------------------Ép kiểu Convert----------------
            //int d = Convert.ToInt32("123");
           // Console.WriteLine(d); // chuyển chuỗi sang số
            //bool e = Convert.ToBoolean(27);
            //Console.WriteLine(e); //chuyễn số sang bool


            //--ví dụ----------

            //Console.WriteLine("Nhap tuoi: ");
            //int age = int.Parse(Console.ReadLine());



            //----------------------------------------------Các TOÁN TỬ--------------------
            //dễ
            //------------------------------------Cá phép tính toán hàm math-------
            int x = 10;
            int y = 4;

            Console.WriteLine( Math.Pow(x, y) - Math.Sqrt(x)  );
             

        }
    }
}
