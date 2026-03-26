using System;

public abstract class Place
{
    // Encapsulamiento: Variables privadas con guion bajo
    protected string _name;
    protected string _address;
    protected double _rating;

    public Place(string name, string address, double rating)
    {
        _name = name;
        _address = address;
        _rating = rating;
    }

    // Polimorfismo: Cada tipo de lugar calculará su "Pet Score" diferente
    public abstract double CalculatePetScore();

    // Método virtual que todos comparten pero pueden mejorar
    public virtual string GetDetails()
    {
        return $"{_name} - Located at: {_address} (Rating: {_rating}/5)";
    }
}