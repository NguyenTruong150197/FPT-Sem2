using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Product[] products = new Product[5];
            products[0] = new Book("Book1", "Book no 1", 10.99);
            products[1] = new Book("Book2", "Book no 2", 14.99);
            products[2] = new Book("Book3", "Book no 3", 19.99);
            products[3] = new Phone("Phone1", "Iphone 14 Promax", 1999.99);
            products[4] = new Phone("Phone2", "Samsung Galaxy S23 Ultra", 1888.99);

            double totalBookTax = 0;
            double totalPhoneTax = 0;

            foreach (Product product in products)
            {
                if (product is Book)
                    totalBookTax += product.computeTax();
                else if (product is Phone)
                    totalPhoneTax += product.computeTax();
            }

            Console.WriteLine("Total tax for Books: " + totalBookTax);
            Console.WriteLine("Total tax for Phones: " + totalPhoneTax);
            Console.ReadKey();
        }
    }
}
