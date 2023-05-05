using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate
{
    internal class Program
    {
        public delegate int Calculation(int num1, int num2);

        public static int Sum(int a, int b) => a + b;

        public static int Sub(int a, int b) => a - b;

        public static int Mul(int a, int b) => a * b;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int result;
            Calculation calculation = new Calculation(Sum);
            result = calculation(20, 10);
            Console.WriteLine("Tổng = " + result);

            Calculation calculation1 = new Calculation(Sub);
            result = calculation1(20, 10);
            Console.WriteLine("Hiệu = " + result);

            Calculation calculation2 = new Calculation(Mul);
            result = calculation2(20, 10);
            Console.WriteLine("Tích = " + result);

            Console.ReadKey();
        }
    }
}
