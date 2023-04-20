using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_AbstractClass
{
    public abstract class Nhanvien
    {
        /* public string hoten;
         * public double luongcoban; */
        protected string hoten;
        protected double luongcoban;

        /* public Nhanvien() { }

         * public Nhanvien(string hoten, double luongcoban)
         * {
         *    this.hoten = hoten;
         *    this.luongcoban = luongcoban;
         * } */

        public virtual void Nhap()
        {
            Console.Write("Nhập tên nhân viên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập lương cơ bản: ");
            luongcoban = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Hienthi()
        {
            Console.WriteLine($"Họ tên: {hoten}");
            Console.WriteLine($"Lương cơ bản: {luongcoban}");
        }

        public abstract double Tinhluong();
    }
}
