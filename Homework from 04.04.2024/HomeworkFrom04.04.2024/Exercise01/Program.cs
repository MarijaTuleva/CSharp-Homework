

using Exercise01.Domain;
using Exercise01.Domain.Models;

GenericPetStore<Cat> CatStore = new GenericPetStore<Cat>();
GenericPetStore<Dog> DogStore = new GenericPetStore<Dog>();
GenericPetStore<Fish> FishStore = new GenericPetStore<Fish>();

CatStore.Insert(new Cat("Dragana", "Birman", 2, true, 8));
CatStore.Insert(new Cat("Stefi", "Bombay", 4,  false, 1));

DogStore.Insert(new Dog("Antonij", "Doberman", 8, true, "Chicken"));
DogStore.Insert(new Dog("Pongo", "Dalmatian", 5, false, "Duck"));

FishStore.Insert(new Fish("Dory", "Blue Tang", 1, "Blue", 30));
FishStore.Insert(new Fish("Marlin", "Clown Fish", 2, "Orange", 11));

CatStore.BuyPet("Dragana");
CatStore.BuyPet("Mari");
DogStore.BuyPet("Pongo");
DogStore.BuyPet("Peci");

CatStore.PrintsPets();
DogStore.PrintsPets();
FishStore.PrintsPets();

