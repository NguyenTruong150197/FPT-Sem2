using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_AbstractClass
{
    public class NVKythuat : Nhanvien
    {
        /* public int ngaycong; */
        protected int ngaycong;

        /* public NVKythuat()
         * {
         * }

         * public NVKythuat(string hoten, double luongcoban, int ngaycong) : base(hoten, luongcoban)
         * {
         *     this.ngaycong = ngaycong;
         * } */

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngày công: ");
            ngaycong = Convert.ToInt32(Console.ReadLine());
        }

        public override void Hienthi()
        {
            base.Hienthi();
            Console.WriteLine($"Ngày công: {ngaycong}");
        }

        public override double Tinhluong()
        {
            return luongcoban + ngaycong * 100000;
        }
    }
}
