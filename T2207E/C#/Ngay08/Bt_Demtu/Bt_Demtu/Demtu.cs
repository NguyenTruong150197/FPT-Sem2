using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_Demtu
{
    internal class Demtu
    {
        public string str;

        public Demtu() { str = ""; }

        public Demtu(string str)
        {
            this.str = str;
        }

        public void InputString()
        {
            Console.WriteLine("Nhập vào các chuỗi, nhập chuỗi trống để kết thúc");
            while (true)
            {
                str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) { break; }
            }
            string[] words = str.Split(' ');
            foreach (string word in words)
            {

            }
        }
    }
}
