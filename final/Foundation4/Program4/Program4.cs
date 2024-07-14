class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(30, 5);
        Swimming swim = new Swimming(45, 20);
        Cycling cycle = new Cycling(60, 15);

        Exercise[] exercises = { run, swim, cycle };
        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine($"{exercise.GetType().Name} burned {exercise.CalculateCaloriesBurned()} calories");
        }
    }
}
