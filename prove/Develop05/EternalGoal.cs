using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetails()
    {
        return $"{_name} - {_description} (Points: {_points}) - Ongoing";
    }

    public override string GetSaveString()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}