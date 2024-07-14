using System;
using System.Collections.Generic;
using System.Linq;

public class PetManager
{
    private List<Pet> _pets = new List<Pet>();

    public void AddPet(Pet pet)
    {
        _pets.Add(pet);
    }

    public string DisplayPets()
    {
        return string.Join("\n", _pets.Select(p => p.GetDetails()));
    }
}