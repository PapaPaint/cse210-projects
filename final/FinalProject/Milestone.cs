using System;

public class Milestone
{
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public Pet Pet { get; set; }

    public Milestone(string description, DateTime date, Pet pet)
    {
        Description = description;
        Date = date;
        Pet = pet;
    }

    public string GetDetails()
    {
        return $"Milestone: {Description}, Date: {Date.ToShortDateString()}, Pet: {Pet.Name}";
    }
}