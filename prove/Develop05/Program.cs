using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveProgress();
                    break;
                case "5":
                    LoadProgress();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            case "3":
                goals.Add(new EternalGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < goals.Count)
        {
            int points = goals[choice].RecordEvent();
            totalPoints += points;
            Console.WriteLine($"Event recorded. Points awarded: {points}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    static void SaveProgress()
    {
        using (StreamWriter outputFile = new StreamWriter("progress.txt"))
        {
            outputFile.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine("Progress saved.");
    }

    static void LoadProgress()
    {
        if (File.Exists("progress.txt"))
        {
            string[] lines = File.ReadAllLines("progress.txt");
            totalPoints = int.Parse(lines[0]);
            goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                switch (type)
                {
                    case "SimpleGoal":
                        var simpleGoal = new SimpleGoal(data[0], data[1], int.Parse(data[2]))
                        {
                            IsCompleteProperty = bool.Parse(data[3])
                        };
                        goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        var checklistGoal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5]))
                        {
                            CurrentCount = int.Parse(data[3])
                        };
                        goals.Add(checklistGoal);
                        break;
                }
            }
            Console.WriteLine("Progress loaded.");
        }
        else
        {
            Console.WriteLine("No saved progress found.");
        }
    }
}
