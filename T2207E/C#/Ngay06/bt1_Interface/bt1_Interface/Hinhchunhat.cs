using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1_Interface
{
    public class Hinhchunhat : Hinh
    {
        private double Dai;
        private double Rong;

        public Hinhchunhat() { this.Dai = 0; this.Rong = 0;}

        public Hinhchunhat(double Dai, double Rong)
        {
            this.Dai = Dai;
            this.Rong = Rong;
        }

        public double getDai() { return this.Dai; }

        public void setDai(double Dai) { this.Dai = Dai; }

        public double getRong() { return this.Rong; }

        public void setRong(double Rong) { this.Rong = Rong; }

        public virtual void Nhap()
        {
            Console.Write("Nhập cạnh thứ nhất của hình chữ nhật: ");
            Dai = double.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh thứ 2 của hình chữ nhật: ");
            Rong = double.Parse(Console.ReadLine());
        }

        public virtual void Hienthi()
        {
            if (Dai > Rong)
                Console.WriteLine($"Hình chữ nhật có chiều dài: {Dai}, chiều rộng: {Rong}");
            else
                Console.WriteLine($"Hình chữ nhật có chiều dài: {Rong}, chiều rộng: {Dai}");
        }

        public virtual double Chuvi() { return (Dai + Rong) * 2; }

        public virtual double Dientich() { return Dai * Rong; }
    }
}
