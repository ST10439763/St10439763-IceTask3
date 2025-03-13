using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name) 
        {
            this.Name = name;
        }

        public virtual void Display()
        { }
    }
}
