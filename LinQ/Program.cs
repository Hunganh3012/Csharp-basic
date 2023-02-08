using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class chuyendoidulieuBai1
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var students = new List<Student>()
            {
                new Student("B25DCCN100", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh")
            };
            var RegisterSubject = new List<RegisteredSubject>()
            {
                new RegisteredSubject("B25DCCN100", "Java", DateTime.Now),
                new RegisteredSubject("B25DCCN100", "C#", DateTime.Now),
                new RegisteredSubject("B25DCCN100", "SQL", DateTime.Now),
                new RegisteredSubject("B25DCCN105", "Android", DateTime.Now),
                new RegisteredSubject("B25DCCN104", "C#", DateTime.Now),
                new RegisteredSubject("B25DCCN101", "C#", DateTime.Now)
            };

            var StudentInHanoi = from hocsinh in students 
                                 // gán hocsinh trong bảng students
                                    //group hocsinh by hocsinh.Address; //nhóm lại các hoc sinh thong qua
                                 where hocsinh.Address == "Hà Nội" //( điều kiện)
                                 // orderby hocsinh.Id descending //(' sắp xếp giảm dần).
                                 select hocsinh;
            foreach(var n in StudentInHanoi)
            {
                Console.WriteLine(n.ToString()); 
            }
            /*foreach (var i in StudentInHanoi)
            {
                Console.WriteLine($"==> {i.Key} ");
                foreach( var n in i)
                {
                    Console.WriteLine(n);
                }
            }
            */
        }
       

    }
}
