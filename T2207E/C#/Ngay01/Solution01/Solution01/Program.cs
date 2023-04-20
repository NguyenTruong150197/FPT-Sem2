using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int n;
            int giaithua = 1;
            Console.WriteLine("Nhập số n = ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0 )
            {
                Console.WriteLine($"Giai thừa của {n} = 1");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    giaithua *= i;
                }
                Console.WriteLine($"Giai thừa của {n} = {giaithua}");
            }
            Console.ReadKey();
        }
    }
}
