public class Dog : Pet
{
    private string _breed;

    public Dog(string name, int age, float weight, string breed) : base(name, age, weight)
    {
        _breed = breed;
    }

    public override string GetDetails()
    {
        return $"Dog: Name={_name}, Age={_age}, Weight={_weight}, Breed={_breed}";
    }

    public string MakeSound()
    {
        return "Woof!";
    }
}