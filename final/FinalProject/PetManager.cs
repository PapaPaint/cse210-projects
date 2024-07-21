using System;
using System.Collections.Generic;

public class PetManager
{
    private List<Pet> pets;
    private List<HealthRecord> healthRecords;
    private List<Schedule> schedules;
    private List<Reminder> reminders;
    private List<Milestone> milestones;

    public PetManager()
    {
        pets = new List<Pet>();
        healthRecords = new List<HealthRecord>();
        schedules = new List<Schedule>();
        reminders = new List<Reminder>();
        milestones = new List<Milestone>();
    }

    public List<Pet> Pets => pets;

    public void AddPet(Pet pet) => pets.Add(pet);
    public void AddHealthRecord(HealthRecord healthRecord) => healthRecords.Add(healthRecord);
    public void SetSchedule(Schedule schedule) => schedules.Add(schedule);
    public void SetReminder(Reminder reminder) => reminders.Add(reminder);
    public void AddMilestone(Milestone milestone) => milestones.Add(milestone);

    public string DisplayPets()
    {
        var result = new System.Text.StringBuilder("Pets:\n");
        foreach (var pet in pets)
        {
            result.AppendLine(pet.GetDetails());
        }
        return result.ToString();
    }

    public string DisplayHealthRecords()
    {
        var result = new System.Text.StringBuilder("Health Records:\n");
        foreach (var record in healthRecords)
        {
            result.AppendLine(record.GetDetails());
        }
        return result.ToString();
    }

    public string DisplaySchedules()
    {
        var result = new System.Text.StringBuilder("Schedules:\n");
        foreach (var schedule in schedules)
        {
            result.AppendLine(schedule.GetDetails());
        }
        return result.ToString();
    }

    public string DisplayReminders()
    {
        var result = new System.Text.StringBuilder("Reminders:\n");
        foreach (var reminder in reminders)
        {
            result.AppendLine(reminder.GetDetails());
        }
        return result.ToString();
    }

    public string DisplayMilestones()
    {
        var result = new System.Text.StringBuilder("Milestones:\n");
        foreach (var milestone in milestones)
        {
            result.AppendLine(milestone.GetDetails());
        }
        return result.ToString();
    }
}