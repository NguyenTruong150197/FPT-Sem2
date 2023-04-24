using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexer
{
    internal class StudentList
    {
        private Student[] list = new Student[10];
        
        public StudentList()
        {
            for(int i = 0; i < list.Length; i++)
            {
                list[i] = new Student();
            }
        }

        public Student this[int i]
        {
            get => list[i];
            set => list[i] = value;
        }
    }
}
