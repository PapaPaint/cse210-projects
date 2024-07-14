using System;

class Program
{
    static void Main(string[] args)
    {
        PetManager petManager = new PetManager();

        Dog dog1 = new Dog("Buddy", 3, 15.5f, "Labrador");
        Cat cat1 = new Cat("Whiskers", 2, 4.5f, "Short Hair");

        petManager.AddPet(dog1);
        petManager.AddPet(cat1);

        Console.WriteLine("Pet Details:");
        Console.WriteLine(petManager.DisplayPets());
    }
}