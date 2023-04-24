using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexer
{
    internal class StudentList1
    {
        //khai báo field dạng mảng
        public Student[] list = new Student[10];
        public StudentList1()
        {
            for (int i= 0; i < list.Length; i++)
                list[i] = new Student();
        }

    }
}
