using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bt_ShopMenu
{
    internal class Product
    {
        private string ID;
        private string Name;
        private double Price;

        public string setID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        public string setName
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public double setPrice
        {
            get { return this.Price; }
            set { this.Price = value; }
        }

        public Product()
        {
            ID = "";
            Name = "";
            Price = 0.0;
        }

        public Product(string ID, string Name, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
        }

        public void Input()
        {
            Console.WriteLine("Enter Product ID:");
            Console.Write("Enter Product ID: ");
            ID = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            Price = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            string str = string.Format("{0, -1}, {0, -15}, {0, -27}", ID, Name, Price);
            Console.WriteLine(str);
        }
    }
}
