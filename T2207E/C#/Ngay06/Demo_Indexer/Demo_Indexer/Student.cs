using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexer
{
    internal class Student
    {
        private string MaSV;
        private string Hoten;

        public Student()
        {
            this.MaSV = "";
            this.Hoten = "";
        }

        public Student(string MaSV, string Hoten)
        {
            this.MaSV = MaSV;
            this.Hoten = Hoten;
        }

        public string getMaSV() => this.MaSV;

        public void setMaSV(string MaSV) { this.MaSV = MaSV; }

        public string getHoten() => this.Hoten;

        public void setHoten(string Hoten) {  this.Hoten = Hoten; }

        public void Input()
        {
            Console.Write("Nhập mã sinh viên: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên: ");
            Hoten = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Mã sinh viên: " + MaSV);
            Console.WriteLine("Họ tên: " +  Hoten);
        }
    }
}
