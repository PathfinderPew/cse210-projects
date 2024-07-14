public class Wedding : Event
{
    public string CoupleNames { get; set; }

    public Wedding(string name, string date, string coupleNames)
        : base(name, date)
    {
        CoupleNames = coupleNames;
    }

    public override void DisplayEventDetails()
    {
        base.DisplayEventDetails();
        Console.WriteLine($"Couple: {CoupleNames}");
    }
}
