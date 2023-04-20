using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_AbstractClass
{
    public class NVKinhdoanh : Nhanvien
    {
        /* public double doanhthu; */
        protected double doanhthu;

        /* public NVKinhdoanh()
         * {
         * }

         * public NVKinhdoanh(string hoten, double luongcoban, double doanhthu) : base(hoten, luongcoban)
         * {
         *     this.doanhthu = doanhthu;
         * } */

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập doanh thu: ");
            doanhthu = Convert.ToDouble(Console.ReadLine());
        }

        public override void Hienthi()
        {
            base.Hienthi();
            Console.WriteLine($"Doanh thu: {doanhthu}");
        }

        public override double Tinhluong()
        {
            return luongcoban + doanhthu * 10/100;
        }
    }
}
