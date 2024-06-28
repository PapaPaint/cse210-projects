using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public bool IsCompleteProperty
    {
        get { return _isComplete; }
        set { _isComplete = value; }
    }

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetails()
    {
        return $"{_name} - {_description} (Points: {_points}) - Completed: {_isComplete}";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}
