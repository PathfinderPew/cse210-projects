public class Event
{
    public string Name { get; set; }
    public string Date { get; set; }

    public Event(string name, string date)
    {
        Name = name;
        Date = date;
    }

    public virtual void DisplayEventDetails()
    {
        Console.WriteLine($"Event: {Name}");
        Console.WriteLine($"Date: {Date}");
    }
}
