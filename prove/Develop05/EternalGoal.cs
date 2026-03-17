// --- ETERNAL GOAL ---
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override int RecordEvent() => int.Parse(_points);

    public override bool IsComplete() => false; // Nunca se completa

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}