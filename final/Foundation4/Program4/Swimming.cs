public class Swimming : Exercise
{
    public int Laps { get; set; }

    public Swimming(int duration, int laps)
        : base(duration)
    {
        Laps = laps;
    }

    public override double CalculateCaloriesBurned()
    {
        return Duration * 8; // Simplified calculation
    }
}
