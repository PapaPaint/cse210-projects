using System;


class Resume
{
    // Member variables
    public string _name;

    // Start list to a new list before use
    public List<Job> _jobs = new List<Job>();

    // Display method
    public void Diplay()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}