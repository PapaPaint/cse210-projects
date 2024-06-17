using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    //I was missing the void part here hence I ran into a problem
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}