public class Activity : Place
{
    private bool _isLeashFree;

    public Activity(string name, string address, double rating, bool leashFree) 
        : base(name, address, rating)
    {
        _isLeashFree = leashFree;
    }

    public override double CalculatePetScore()
    {
        return _isLeashFree ? _rating + 2 : _rating;
    }

    public override string GetDetails()
    {
        string leashInfo = _isLeashFree ? "Leash-free area!" : "Leash required";
        return base.GetDetails() + $"\n   Type: Outdoor Activity | {leashInfo}";
    }
}