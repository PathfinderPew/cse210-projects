public class Concert : Event
{
    public string HeadlinerBand { get; set; }

    public Concert(string name, string date, string headlinerBand)
        : base(name, date)
    {
        HeadlinerBand = headlinerBand;
    }

    public override void DisplayEventDetails()
    {
        base.DisplayEventDetails();
        Console.WriteLine($"Headliner: {HeadlinerBand}");
    }
}
