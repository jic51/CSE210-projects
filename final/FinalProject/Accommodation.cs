public class Accommodation : Place
{
    private double _petFee;
    private bool _allowsLargeDogs;

    public Accommodation(string name, string address, double rating, double fee, bool largeDogs) 
        : base(name, address, rating)
    {
        _petFee = fee;
        _allowsLargeDogs = largeDogs;
    }

    public override double CalculatePetScore()
    {
        // Lógica: Si la tarifa es 0, el puntaje sube mucho
        double score = _rating;
        if (_petFee == 0) score += 2;
        if (_allowsLargeDogs) score += 1;
        return score;
    }

    public override string GetDetails()
    {
        string sizeInfo = _allowsLargeDogs ? "All sizes welcome" : "Small pets only";
        return base.GetDetails() + $"\n   Fee: ${_petFee} | {sizeInfo}";
    }
}