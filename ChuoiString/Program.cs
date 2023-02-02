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
            thongbao = thongbao.TrimEnd(); // Xóa bỏ các kí tự cho trước trong key hoặc chars ở đầu và cuối string
                                        //và trả về string sau khi xóa. Nếu không cung cấp tham số thì hàm xóa bỏ các kí tự khoảng trắng.
            Console.WriteLine(thongbao); // Nguyen Hung Anh .. đã xóa khoảng trăng
            
            thongbao = thongbao.Trim().Insert(0, "  Lớp:12"); // Tương tự, Hàm Insert Chèn value vào vị trí startPos của string hiện tại
                                                              // và trả về string mới sau khi chèn. Insert( StartPos, value).
            Console.WriteLine(thongbao); // Lớp:12Nguyen Hung Anh
            thongbao = thongbao.Replace("Nguyen", "Tran"); //	Trả về một string sau khi thay thế tất cả các kí tự
                                                             //	hoặc string old bởi kí tự hoặc string trong tham số new. Replace(old,new).
            Console.WriteLine(thongbao);
         
        }

         
    }
}
