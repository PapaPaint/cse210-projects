using System;

public abstract class Pet
{
    public string Name { get; set; }
    public int Age { get; set; }
    public float Weight { get; set; }

    public Pet(string name, int age, float weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public abstract string GetDetails();
}