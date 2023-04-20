using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    internal class StudentList
    {
        public Student[] list;
        public int n;
        public StudentList()
        {
            list = new Student[10];
            n = 0;
        }

        public int Input()
        {
            do
            {

            } while ();

            Console.WriteLine("Nhập thông tin sinh viên:");
            Console.Write("Nhập số sinh viên cần nhập thông tin: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                list[i] = new Student();
                list[i].Input();
            }

            return n;
        }

        public void Display()
        {
            Console.WriteLine("Danh sách sinh viên:");
            for (int i = 0; i < n; i++)
            {
                list[i].Display();
            }
        }

        public void SortByMark()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (list[i].Mark < list[j].Mark)
                    {
                        Student temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public int Search(string key)
        {
            for (int i = 0; i < n; i++)
            {
                if (list[i].Rollno == key || list[i].Name == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
