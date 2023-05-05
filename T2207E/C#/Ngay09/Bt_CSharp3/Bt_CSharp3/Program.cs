using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_CSharp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Product[] product = new Product[5];
            product[0] = new Book("B01", "Book A", 10.00);
            product[1] = new Book("B02", "Book B", 20.00);
            product[2] = new Book("B03", "Book C", 30.00);
            product[3] = new Phone("P01", "Phone 1", 40.00);
            product[4] = new Phone("P02", "Phone 2", 50.00);

            double totalBookTax = 0;
            double totalPhoneTax = 0;

            foreach(Product p in product)
            {
                if (p is Book)
                    totalBookTax += p.computeTax();
                else if (p is Phone)
                    totalPhoneTax += p.computeTax();
            }

            Console.WriteLine("Total tax of Books: " + totalBookTax);
            Console.WriteLine("Total tax of Phone: " + totalPhoneTax);
            Console.ReadKey();
        }
    }
}
