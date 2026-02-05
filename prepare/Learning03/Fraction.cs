using System;
using System.ComponentModel;

public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;

  }

  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;

  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    SetBottom(bottom);
  }
  
  public void SetBottom(int bottom)
  {
    if (bottom == 0 )
    {
      _bottom = 1;
    }
    else
    {
      _bottom = bottom;

    }
  }

  public int GetBottom()
    {
        return _bottom;
    }
  
  public int GetTop()
  {
    return _top;
  }

  public void SetTop(int top)
  {
    _top = top;
  }

  public string GetFractionString() => $"{_top}/{_bottom}";
  public double GetDecimalValue() => (double)_top / _bottom;

}