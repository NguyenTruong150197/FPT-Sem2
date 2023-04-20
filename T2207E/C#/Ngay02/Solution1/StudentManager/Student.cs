using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    internal class Student
    {
        private string rollno;
        private string name;
        private float mark;

        public string Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public float Mark { get => mark; set => mark = value; }

        public Student()
        {
            rollno = "";
            name = "";
            mark = 0;
        }

        public Student(string rollno, string name, float mark)
        {
            this.rollno = rollno;
            this.name = name;
            this.mark = mark;
        }

        public void Input()
        {
            Console.Write("Mã sinh viên: ");
            rollno = Console.ReadLine();
            Console.Write("Họ tên: ");
            name = Console.ReadLine();
            Console.Write("Điểm: ");
            mark = float.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Thông tin sinh viên:");
            Console.WriteLine("Mã sinh viên: " + rollno);
            Console.WriteLine("Họ tên: " +  name);
            Console.WriteLine("Điểm: " + mark);
        }
    }
}
