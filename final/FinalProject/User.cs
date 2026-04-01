using System;
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
        string placeName = place.GetDetails().Split('-')[0];
        Console.WriteLine($"--- {placeName} added to favorites! ---");
    }

    public void DisplayFavorites() 
    {
        Console.WriteLine($"\n⭐ {_name}'s Favorite Pet-Friendly Spots:");
        if (_favorites.Count == 0) 
        {
            Console.WriteLine("No favorites added yet.");
        }
        else 
        {
            foreach (Place p in _favorites) 
            {
                Console.WriteLine(p.GetDetails());
            }
        }
    }
}