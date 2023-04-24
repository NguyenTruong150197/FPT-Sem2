using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt2
{
    internal class Animal
    {
        protected string name;
        protected double weight;

        public void SetMe(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}, Weight: {weight}");
        }
    }
}
