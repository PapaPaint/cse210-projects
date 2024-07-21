using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        PetManager petManager = new PetManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Pet Management System");
            Console.WriteLine("1. Add Pet");
            Console.WriteLine("2. View Pets");
            Console.WriteLine("3. Add Health Record");
            Console.WriteLine("4. View Health Records");
            Console.WriteLine("5. Set Schedule");
            Console.WriteLine("6. View Schedules");
            Console.WriteLine("7. Set Reminder");
            Console.WriteLine("8. View Reminders");
            Console.WriteLine("9. Add Milestone");
            Console.WriteLine("10. View Milestones");
            Console.WriteLine("11. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddPet(petManager);
                    break;
                case "2":
                    Console.WriteLine(petManager.DisplayPets());
                    break;
                case "3":
                    AddHealthRecord(petManager);
                    break;
                case "4":
                    Console.WriteLine(petManager.DisplayHealthRecords());
                    break;
                case "5":
                    SetSchedule(petManager);
                    break;
                case "6":
                    Console.WriteLine(petManager.DisplaySchedules());
                    break;
                case "7":
                    SetReminder(petManager);
                    break;
                case "8":
                    Console.WriteLine(petManager.DisplayReminders());
                    break;
                case "9":
                    AddMilestone(petManager);
                    break;
                case "10":
                    Console.WriteLine(petManager.DisplayMilestones());
                    break;
                case "11":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddPet(PetManager petManager)
    {
        Console.Write("Enter pet type (dog/cat): ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Enter pet name: ");
        string name = Console.ReadLine();

        Console.Write("Enter pet age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter pet weight: ");
        float weight = float.Parse(Console.ReadLine());

        if (type == "dog")
        {
            Console.Write("Enter breed: ");
            string breed = Console.ReadLine();
            petManager.AddPet(new Dog(name, age, weight, breed));
        }
        else if (type == "cat")
        {
            Console.Write("Enter fur type: ");
            string furType = Console.ReadLine();
            petManager.AddPet(new Cat(name, age, weight, furType));
        }
        else
        {
            Console.WriteLine("Invalid pet type.");
        }
    }

    static void AddHealthRecord(PetManager petManager)
    {
        Console.Write("Enter visit date (MM/DD/YYYY): ");
        DateTime visitDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter treatment: ");
        string treatment = Console.ReadLine();

        Console.Write("Enter vaccinations: ");
        string vaccinations = Console.ReadLine();

        Console.Write("Enter health metrics: ");
        string healthMetrics = Console.ReadLine();

        petManager.AddHealthRecord(new HealthRecord(visitDate, treatment, vaccinations, healthMetrics));
    }

    static void SetSchedule(PetManager petManager)
    {
        Console.Write("Enter schedule type: ");
        string type = Console.ReadLine();

        Console.Write("Enter schedule time (MM/DD/YYYY HH:MM): ");
        DateTime time = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        petManager.SetSchedule(new Schedule(type, time, description));
    }

    static void SetReminder(PetManager petManager)
    {
        Console.Write("Enter reminder time (MM/DD/YYYY HH:MM): ");
        DateTime reminderTime = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter message: ");
        string message = Console.ReadLine();

        Console.WriteLine("Select a pet:");
        Console.WriteLine(petManager.DisplayPets());
        Console.Write("Enter pet name: ");
        string petName = Console.ReadLine();

        Pet selectedPet = petManager.Pets.FirstOrDefault(p => p.Name == petName);
        if (selectedPet != null)
        {
            petManager.SetReminder(new Reminder(reminderTime, message, selectedPet));
        }
        else
        {
            Console.WriteLine("Pet not found.");
        }
    }

    static void AddMilestone(PetManager petManager)
    {
        Console.Write("Enter milestone description: ");
        string milestoneDescription = Console.ReadLine();

        Console.Write("Enter date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Select a pet:");
        Console.WriteLine(petManager.DisplayPets());
        Console.Write("Enter pet name: ");
        string petName = Console.ReadLine();

        Pet selectedPet = petManager.Pets.FirstOrDefault(p => p.Name == petName);
        if (selectedPet != null)
        {
            petManager.AddMilestone(new Milestone(milestoneDescription, date, selectedPet));
        }
        else
        {
            Console.WriteLine("Pet not found.");
        }
    }

}