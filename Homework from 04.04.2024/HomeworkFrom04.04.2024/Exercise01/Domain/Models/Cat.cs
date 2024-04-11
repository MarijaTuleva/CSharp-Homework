using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, bool lazy, int livesLeft) 
        {
            Name = name;
            Type = type;
            Age = age;
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override string PrintInfo()
        {
            return $"{Name} is a {Type}, it's {Age} years old, and it has {LivesLeft} lives left.";
        }
    }
}
