using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exam
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
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract double computeTax();
    }
}
