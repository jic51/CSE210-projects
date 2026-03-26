public class Dining : Place
{
    private bool _hasPetMenu;

    public Dining(string name, string address, double rating, bool hasPetMenu) 
        : base(name, address, rating)
    {
        _hasPetMenu = hasPetMenu;
    }

    public override double CalculatePetScore()
    {
        return _hasPetMenu ? _rating + 1.5 : _rating;
    }

    public override string GetDetails()
    {
        string menuInfo = _hasPetMenu ? "Special pet menu available 🐶" : "Standard pet-friendly seating";
        return base.GetDetails() + $"\n   Type: Dining | {menuInfo}";
    }
}