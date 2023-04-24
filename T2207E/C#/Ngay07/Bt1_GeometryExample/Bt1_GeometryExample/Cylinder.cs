using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt1_GeometryExample
{
    internal class Cylinder
    {
        public double radius, height;
        private double baseArea, lateralArea, totalArea, volume;

        public Cylinder()
        {
            radius = 0;
            height = 0;
        }

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Input()
        {
            Console.WriteLine("Enter the dimensitions of the cylinder");
            Console.Write("Radius: ");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        public void Process()
        {
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine($"Radius: {radius}, Height: {height}");
            Console.WriteLine($"Base: {baseArea.ToString("F2")}, Lateral: {lateralArea.ToString("F2")}, Total: {totalArea.ToString("F2")}, Volume: {volume.ToString("F2")}");
        }
    }
}
