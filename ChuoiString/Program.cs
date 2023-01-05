using System;

namespace ChuoiString
{
    class Program
    {
        public string name;
        public string price;
       public string Info
        {
            get
            {
                return $"{name},{price}";
            }
        }
        static void Main(string[] args)
        {
        string thongbao = "      Nguyen Hung Anh";
            Console.WriteLine(thongbao);
            thongbao = thongbao.Trim();
            Console.WriteLine(thongbao);
            thongbao = thongbao.Trim().Insert(0, "  Lớp:12");
            Console.WriteLine(thongbao);
            thongbao = thongbao.Replace("Nguye", "Tran");
            Console.WriteLine(thongbao);

        } 
    }
}
