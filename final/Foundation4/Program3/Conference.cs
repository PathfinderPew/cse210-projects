public class Conference : Event
{
    public string KeynoteSpeaker { get; set; }

    public Conference(string name, string date, string keynoteSpeaker)
        : base(name, date)
    {
        KeynoteSpeaker = keynoteSpeaker;
    }

    public override void DisplayEventDetails()
    {
        base.DisplayEventDetails();
        Console.WriteLine($"Keynote Speaker: {KeynoteSpeaker}");
    }
}
