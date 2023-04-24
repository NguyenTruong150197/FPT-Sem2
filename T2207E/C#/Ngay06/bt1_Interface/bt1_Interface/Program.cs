using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1_Interface
{ 
    internal class Program
    {
        public static void Work(Hinh hinh)
        {
            hinh.Nhap();
            hinh.Hienthi();
            Console.WriteLine("Diện tích của hình là: {0}", hinh.Dientich());
            Console.WriteLine("Chu vi của hình là: {0}", hinh.Chuvi());
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int choice = 0;

            do
            {
                Console.WriteLine("1. Hình chữ nhât");
                Console.WriteLine("2. Hình vuông");
                Console.WriteLine("3. Hình tròn");
                Console.WriteLine("4. Thoát");
                Console.Write("Mời bạn chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Hinhchunhat hcn = new Hinhchunhat();
                        Work(hcn);
                        break;
                    case 2:
                        Hinhvuong hv = new Hinhvuong();
                        Work(hv);
                        break;
                    case 3:
                        Hinhtron ht = new Hinhtron();
                        Work(ht);
                        break;
                    case 4:
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Nhập không hợp lệ!");
                        break;
                }
            } while (choice != 4);

            Console.ReadLine();
        }
    }
}
