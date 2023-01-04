using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Person
    {
        //mặc định
        public Person() { }
        //Dạng contructor có 2 đối số;
        public Person(string name, ushort age) {
            Console.WriteLine("Name:"+name + "Age:" + age);
        }


        //thuộc tính
        private string _name;
        private ushort _age;

        //Phương thức
        public void SetName(string name)
        {
            this._name = name;
        }
        public void SayName()
        {
            Console.WriteLine(this._name);
        } 
    }
}
