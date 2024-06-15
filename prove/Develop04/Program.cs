using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(duration);
                    breathingCount++;
                    break;
                case "2":
                    activity = new ReflectingActivity(duration);
                    reflectingCount++;
                    break;
                case "3":
                    activity = new ListingActivity(duration);
                    listingCount++;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            activity.RunActivity();
        }

        // Exceeding Requirements: Keeping a log of how many times activities were performed.
        Console.WriteLine("\nActivity Summary:");
        Console.WriteLine($"Breathing Activities: {breathingCount}");
        Console.WriteLine($"Reflecting Activities: {reflectingCount}");
        Console.WriteLine($"Listing Activities: {listingCount}");
        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}