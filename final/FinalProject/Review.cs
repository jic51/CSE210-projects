public class Review
{
    private string _userName;
    private string _comment;
    private int _score;

    public Review(string user, string comment, int score)
    {
        _userName = user;
        _comment = comment;
        _score = score;
    }

    public string GetReviewText()
    {
        return $"[{_score}/5] {_userName}: {_comment}";
    }
}