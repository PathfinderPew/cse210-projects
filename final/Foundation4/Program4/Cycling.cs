public class Cycling : Exercise
{
    public double Speed { get; set; } // speed in km/h

    public Cycling(int duration, double speed)
        : base(duration)
    {
        Speed = speed;
    }

    public override double CalculateCaloriesBurned()
    {
        return Duration * 6; // Simplified calculation
    }
}
