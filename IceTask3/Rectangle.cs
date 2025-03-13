using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    class Rectangle : Shape, ICalculateArea
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangle(string name, double width, double length) : base(name)
        {
            this.Width = width;
            this.Length = length;
        }

        public void calculateArea()
        {
            Console.WriteLine($"{Name} Area: {(Width*Length)}");
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nWidth: {Width}" +
                $"\nLength: {Length}");
        }
    }
}
