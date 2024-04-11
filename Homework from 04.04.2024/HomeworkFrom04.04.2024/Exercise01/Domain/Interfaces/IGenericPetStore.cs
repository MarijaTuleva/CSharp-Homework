using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Interfaces
{
    public interface IGenericPetStore<T>
    {
        public void PrintsPets();
        public void Insert(T item);
        public void BuyPet(string name);
    }
}
