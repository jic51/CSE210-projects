using System;

public abstract class Place 
{
    protected string _name;
    protected string _address;
    protected double _rating;

    public Place(string name, string address, double rating) 
    {
        _name = name;
        _address = address;
        _rating = rating;
    }

    public abstract double CalculatePetScore();

    public virtual string GetDetails() 
    {
        return $"{_name} - {_address} (Rating: {_rating}/5)";
    }
}