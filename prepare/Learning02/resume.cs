using System; // Assuming the Job class is in the same namespace as Resume class
// If Job class is in a different namespace, import that namespace here

public class Resume
{
    public string _personName = "Brandon Pew"; // Updated with the name "Brandon Pew"
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
