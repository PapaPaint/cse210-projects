public class Schedule
{
    public string Type { get; set; }
    public DateTime Time { get; set; }
    public string Description { get; set; }

    public Schedule(string type, DateTime time, string description)
    {
        Type = type;
        Time = time;
        Description = description;
    }

    public string GetDetails()
    {
        return $"Type: {Type}, Time: {Time}, Description: {Description}";
    }
}
