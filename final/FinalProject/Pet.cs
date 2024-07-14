public abstract class Pet
{
    protected string _name;
    protected int _age;
    protected float _weight;

    public Pet(string name, int age, float weight)
    {
        _name = name;
        _age = age;
        _weight = weight;
    }

    public abstract string GetDetails();
}