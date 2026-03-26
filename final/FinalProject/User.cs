using System.Collections.Generic;

public class User
{
    private string _name;
    private List<Place> _favorites = new List<Place>();

    public User(string name)
    {
        _name = name;
    }

    public void AddToFavorites(Place place)
    {
        _favorites.Add(place);
        Console.WriteLine($"--- {place.GetDetails().Split('-')[0]} added to favorites! ---");
    }

    public void DisplayFavorites()
    {
        Console.WriteLine($"\n⭐ {_name}'s Favorite Pet-Friendly Spots:");
        foreach (var place in _favorites)
        {
            Console.WriteLine(place.GetDetails());
        }
    }
}
