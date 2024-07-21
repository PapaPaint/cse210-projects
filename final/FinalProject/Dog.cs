public class Dog : Pet
{
    public string Breed { get; set; }

    public Dog(string name, int age, float weight, string breed) : base(name, age, weight)
    {
        Breed = breed;
    }

    public override string GetDetails()
    {
        return $"Dog: Name={Name}, Age={Age}, Weight={Weight}, Breed={Breed}";
    }
}