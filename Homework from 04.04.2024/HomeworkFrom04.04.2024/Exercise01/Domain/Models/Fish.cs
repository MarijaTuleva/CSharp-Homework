using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, string type, int age, string color, int size) 
        {
            Name = name;
            Type = type;
            Age = age;
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"{Name} is a {Type}, it's {Age} years old, it's {Color} and it's {Size} cm big";
        }
    }
}
