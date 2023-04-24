using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1_Interface
{
    public class Hinhvuong : Hinhchunhat
    {
        private double Canh;

        public Hinhvuong() : base() { this.Canh = 0; }

        public Hinhvuong(double Canh) : base(Canh, Canh) { this.Canh = Canh; }

        public double getCanh() { return this.Canh; }

        public void setCanh(double Canh) { this.Canh = Canh; setDai(Canh); setRong(Canh); }

        public override void Nhap()
        {
            Console.Write("Nhập cạnh hình vuông: ");
            Canh = double.Parse(Console.ReadLine());
        }

        public override void Hienthi()
        {
            Console.WriteLine("Hình vuông có cạnh: " + Canh);
        }

        public override double Chuvi() => Canh * 4;
        // public override double Chuvi() { return Canh * 4; }

        public override double Dientich() => Canh * Canh;
        // public override double Dientich() { return Canh * Canh; }
    }
}
