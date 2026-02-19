public class Assignment
{
    // Private atributes
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // methots for all
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // "Getter" por child classes.
    public string GetStudentName()
    {
        return _studentName;
    }
}