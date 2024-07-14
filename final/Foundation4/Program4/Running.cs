public class Running : Exercise
{
    public double Distance { get; set; } // distance in kilometers

    public Running(int duration, double distance)
        : base(duration)
    {
        Distance = distance;
    }

    public override double CalculateCaloriesBurned()
    {
        return Duration * 10; // Simplified calculation
    }
}
