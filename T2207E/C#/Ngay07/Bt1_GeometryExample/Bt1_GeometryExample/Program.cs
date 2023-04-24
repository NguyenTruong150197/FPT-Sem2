using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt1_GeometryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Cylinder cylinder = new Cylinder();
            cylinder.Input();
            cylinder.Process();
            cylinder.Result();

            Console.ReadKey();
        }
    }
}
