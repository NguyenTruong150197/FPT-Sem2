using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            StudentList studentList = new StudentList();
            while (true)
            {
                Console.WriteLine("--------MENU--------");
                Console.WriteLine("1. Nhập danh sách sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Sắp xếp danh sách sinh viên theo điểm giảm dần");
                Console.WriteLine("4. Tìm sinh viên theo họ tên");
                Console.WriteLine("5. Thoát");
                Console.WriteLine("");
                Console.Write("Mời nhập lựa chọn của bạn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        studentList.Input();
                        break;
                    case 2:
                        studentList.Display();
                        break;
                    case 3:
                        studentList.SortByMark();
                        Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo điểm giảm dần:");
                        studentList.Display();
                        break;
                    case 4:
                        Console.WriteLine("Nhập tên hoặc mã sinh viên cần tìm:");
                        string key = Console.ReadLine();
                        int index = studentList.Search(key);
                        if (index != -1)
                        {
                            Console.WriteLine("Tìm thấy sinh viên");
                            studentList.list[index].Display();
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy sinh viên.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Tạm biệt!");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        Console.WriteLine("Mời nhập lại");
                        continue;
                }
            }
            Console.ReadKey();
        }
    }
}
