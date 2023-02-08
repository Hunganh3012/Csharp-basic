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
            var StudentInHanoi = from hocsinh in students
                                 where hocsinh.Address == "Hà Nội"
                                 select hocsinh ;
            foreach (var i in StudentInHanoi)
            {
                Console.WriteLine(i);
            }
        }
        public class RegisteredSubject
        {
            public string StudentId { get; set; }
            public string SubjectName { get; set; }
            public DateTime RegisterTime { get; set; }
            public RegisteredSubject(string studentId,
                string subjectName, DateTime reg)
            {
                StudentId = studentId;
                SubjectName = subjectName;
                RegisterTime = reg;
            }
        }

        public class Student
        {
            public string Id { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public Student(string id, string fullName, string address)
            {
                Id = id;
                FullName = fullName;
                Address = address;
            }
            public override string ToString() => $"Student[{Id}, {FullName}, {Address}]";
        }
    }
}
