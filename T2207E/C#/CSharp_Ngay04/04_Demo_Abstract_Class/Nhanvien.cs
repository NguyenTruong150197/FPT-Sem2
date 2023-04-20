using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstract_Class
{
    public abstract class Nhanvien
    {
        public string hoten;
        public double luongcoban;
        public Nhanvien()
        { 
        }
        public Nhanvien(string hoten, double luongcoban)
        {
            this.hoten = hoten;
            this.luongcoban = luongcoban;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập tên:");
            hoten = Console.ReadLine();
            Console.Write("Lương cơ bản:");
            luongcoban = double.Parse(Console.ReadLine());
        }
        public virtual void Hienthi()
        {
            Console.WriteLine("Họ tên:" + hoten);
            Console.WriteLine("Lương cơ bản: " + luongcoban);
        }
        //định phương thức trừu tượng (chưa nội dung) để lớp con buộc phải kế thừa
        public abstract double Tinhluong();

    }
}
