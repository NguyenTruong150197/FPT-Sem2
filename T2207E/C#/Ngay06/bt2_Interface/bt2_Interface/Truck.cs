using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2_Interface
{
    internal class Truck : Vehicles
    {
        private int truckload;

        public Truck()
        {
            truckload = 0;
        }

        public Truck(string maker, string model, double price, int truckload) : base(maker, model, price)
        {
            this.truckload = truckload;
        }
        
        public int Truckload
        {
            get { return truckload; }
            set { truckload = value; }
        }

        public override void input()
        {
            base.input();
            Console.Write("Enter truckload: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Truckload: " + truckload);
        }
    }
}
