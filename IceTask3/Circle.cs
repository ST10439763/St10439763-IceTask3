using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }

        public void calculateArea()
        {
            Console.WriteLine($"{Name} Area: {(Math.Pow(Radius,2) * Math.PI):F2}");
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nRadius: {Radius}");
        }
    }
}
