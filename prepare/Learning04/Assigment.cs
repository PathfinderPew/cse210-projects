public class Assignment
{
    public string StudentName { get; }
    public string Topic { get; }

    public Assignment(string studentName, string topic)
    {
        StudentName = studentName;
        Topic = topic;
    }

    public string GetSummary()
    {
        return $"{StudentName} - {Topic}";
    }
}
