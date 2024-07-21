public class Cat : Pet
{
    public string FurType { get; set; }

    public Cat(string name, int age, float weight, string furType) : base(name, age, weight)
    {
        FurType = furType;
    }

    public override string GetDetails()
    {
        return $"Cat: Name={Name}, Age={Age}, Weight={Weight}, FurType={FurType}";
    }
}