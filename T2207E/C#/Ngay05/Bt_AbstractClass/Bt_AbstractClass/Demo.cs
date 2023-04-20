using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_AbstractClass
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Nhanvien[] nhanviens = new Nhanvien[10];
            int n;

            do
            {
                Console.Write("Nhập số lượng nhân viên muốn nhập thông tin (1-10): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > 10);

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin của nhân viên " + (i + 1));
                if(i % 2 == 0)
                {
                    nhanviens[i] = new NVKinhdoanh();
                }
                else
                {
                    nhanviens[i] = new NVKythuat();
                }
                nhanviens[i].Nhap();
            }

            Console.WriteLine("Thông tin nhân viên:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhân viên " + (i + 1));
                nhanviens[i].Hienthi();
            }

            Console.ReadKey();
        }
    }
}