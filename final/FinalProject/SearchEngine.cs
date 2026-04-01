using System.Collections.Generic;
using System.Linq;

public class SearchEngine 
{
    private List<Place> _allPlaces = new List<Place>();

    public void AddPlace(Place place) 
    {
        _allPlaces.Add(place);
    }

    public List<Place> GetAllPlaces() 
    {
        return _allPlaces;
    }

    public List<Place> FilterByType<T>() where T : Place 
    {
        return _allPlaces.OfType<T>().Cast<Place>().ToList();
    }
}