using Exercise01.Domain.Interfaces;
using Exercise01.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercise01.Domain
{
    public class GenericPetStore<T> : IGenericPetStore<T> where T : Pet
    {
        private List<T> Pets;
        public GenericPetStore() 
        {
            Pets = new List<T>();
        }

        public void PrintsPets()
        {
            foreach (T item in Pets)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public void Insert(T item)
        {
            Pets.Add(item);
        }

        public void BuyPet(string name)
        {
            T item = Pets.SingleOrDefault(x => x.Name == name);
            if (item == null)
            {
                Console.WriteLine("There isn't a pet by that name.");
            }
            else 
            {
                Pets.Remove(item);
                Console.WriteLine("You have successfully purchased your Pet!");
            }
            


        }

      
    }
}
