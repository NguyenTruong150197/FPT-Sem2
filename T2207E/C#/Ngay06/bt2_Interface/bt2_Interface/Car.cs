using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Interface
{
    internal class Car : Vehicles
    {
        private string color;

        public Car() : base()
        {
            color = "";
        }

        public Car(string maker, string model, double price, string color) : base(maker, model, price)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override void input()
        {
            base.input();
            Console.Write("Enter color: ");
            color = Console.ReadLine();
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Color: " + color);
        }
    }
}
