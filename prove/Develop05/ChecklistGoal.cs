using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int CurrentCount
    {
        get { return _currentCount; }
        set { _currentCount = value; }
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetails()
    {
        return $"{_name} - {_description} (Points: {_points}, Bonus: {_bonusPoints}) - Progress: {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_currentCount},{_targetCount},{_bonusPoints}";
    }
}
