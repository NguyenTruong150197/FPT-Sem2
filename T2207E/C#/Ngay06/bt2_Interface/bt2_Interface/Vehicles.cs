using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Interface
{
    public class Vehicles : IVehicle
    {
        private string maker;
        private string model;
        private double price;

        public Vehicles()
        {
            maker = "";
            model = "";
            price = 0.0;
        }

        public Vehicles(string maker, string model, double price)
        {
            this.maker = maker;
            this.model = model;
            this.price = price;
        }

        public string Maker
        {
            get { return maker; }
            set { maker = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual void input()
        {
            Console.Write("Enter maker: ");
            maker = Console.ReadLine();
            Console.Write("Enter model: ");
            model = Console.ReadLine();
            Console.Write("Enter price: ");
            price = double.Parse(Console.ReadLine());
        }

        public virtual void display()
        {
            Console.WriteLine("Maker: " + maker);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: " + price);
        }
    }
}