using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Lion", 200);
            Tiger tiger = new Tiger("Tiger", 100);

            tiger.Show();
            lion.Show();

            Console.ReadKey();
        }
    }
}
