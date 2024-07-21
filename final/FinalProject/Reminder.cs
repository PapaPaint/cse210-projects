public class Reminder
{
    public DateTime ReminderTime { get; set; }
    public string Message { get; set; }
    public Pet Pet { get; set; }

    public Reminder(DateTime reminderTime, string message, Pet pet)
    {
        ReminderTime = reminderTime;
        Message = message;
        Pet = pet;
    }

    public string GetDetails()
    {
        return $"Reminder Time: {ReminderTime}, Message: {Message}, Pet: {Pet.GetDetails()}";
    }
}