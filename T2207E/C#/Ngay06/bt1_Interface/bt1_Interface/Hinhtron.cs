using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1_Interface
{
    public class Hinhtron : Hinh
    {
        private double Bankinh;

        public Hinhtron() { this.Bankinh = 0; }

        public Hinhtron(double Bankinh) { this.Bankinh = Bankinh; }

        public double getBankinh() { return this.Bankinh; }

        public void setBankinh(double Bankinh) { this.Bankinh = Bankinh; }

        public void Nhap()
        {
            Console.Write("Nhập bán kính hình tròn: ");
            Bankinh = double.Parse(Console.ReadLine());
        }

        public void Hienthi()
        {
            Console.WriteLine("Hình tròn có bán kính: " + Bankinh);
        }

        public double Chuvi() => 2 * Bankinh * Math.PI;
        /* public double Chuvi()
        {
            return 2 * Bankinh * Math.PI;
        } */

        public double Dientich() => Math.PI * Bankinh * Bankinh;
        /* public double Dientich()
        {
            return Math.PI * Bankinh * Bankinh;
        } */
    }
}
