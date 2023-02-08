using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public Student(string id, string fullname, string address)
        {
            Id = id;
            FullName = fullname;
            Address = address;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price ghi đè.
        public override string ToString() => $"Student[{Id}, {FullName}, {Address}]";


    }
}
