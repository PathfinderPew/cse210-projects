public abstract class Exercise
{
    public int Duration { get; set; } // duration in minutes

    public Exercise(int duration)
    {
        Duration = duration;
    }

    public abstract double CalculateCaloriesBurned();
}
