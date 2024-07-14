public class Cat : Pet
{
    private string _furType;

    public Cat(string name, int age, float weight, string furType) : base(name, age, weight)
    {
        _furType = furType;
    }

    public override string GetDetails()
    {
        return $"Cat: Name={_name}, Age={_age}, Weight={_weight}, FurType={_furType}";
    }

    public string MakeSound()
    {
        return "Meow!";
    }
}