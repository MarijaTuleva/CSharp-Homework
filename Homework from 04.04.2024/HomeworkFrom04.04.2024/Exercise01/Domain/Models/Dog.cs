using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavouriteFood { get; set; }

        public Dog(string name, string type, int age, bool goodBoy, string favouriteFood) 
        {
            Name = name;
            Type = type;
            Age = age;
            GoodBoy = goodBoy;
            FavouriteFood = favouriteFood;
        }


        public override string PrintInfo()
        {
            return $"{Name} is a {Type}, it's {Age} years old, and it's favourite food is {FavouriteFood}."; ;
        }
    }
}
