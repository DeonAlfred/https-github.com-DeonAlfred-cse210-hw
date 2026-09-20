class Program
{
    static void Main(string[] args)
    {
        {
        // Create a fraction with the default constructor
        Fraction fraction1 = new Fraction(3);
        Console.WriteLine($"Fraction 1: {fraction1.GetTop()}");
        Console.WriteLine($"Decimal value: {fraction1.GetDecimalValue()}");
        }
        
        {
        }
        
    }
    
}

public class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;

    // Default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return the fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}