using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_CSharp3
{
    public abstract class Product
    {
        private string id;
        private string name;
        private double price;

        public Product()
        {
            id = "";
            name = "";
            price = 0.0;
        }

        public Product(string id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        /* public void Input()
        {
            Console.Write("Nhập mã sách: ");
            id = Console.ReadLine();
            Console.Write("Nhập tên sách: ");
            name = Console.ReadLine();
            Console.Write("Nhập giá sách: ");
            price = double.Parse(Console.ReadLine());
        } */

        public abstract double computeTax();
    }
}
