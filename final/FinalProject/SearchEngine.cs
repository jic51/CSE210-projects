using System.Collections.Generic;
using System.Linq;

public class SearchEngine
{
    private List<Place> _allPlaces = new List<Place>();

    public void AddPlace(Place place)
    {
        _allPlaces.Add(place);
    }

    public List<Place> FilterByType<T>() where T : Place
    {
        // Esto es C# avanzado: filtra la lista por el tipo de clase
        return _allPlaces.OfType<T>().Cast<Place>().ToList();
    }

    public List<Place> GetAllPlaces()
    {
        return _allPlaces;
    }
}
