using System;

class Program
{
    static void Main(string[] args)
    {
        Blind kitchen = new Blind();

        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";

        double materialAmount = kitchen.GetArea();

        Console.WriteLine(
            $"The blind is {kitchen._width} inches wide, " +
            $"{kitchen._height} inches tall, and is painted {kitchen._color}."
        );

        Console.WriteLine($"The area of the blind is {materialAmount} square inches.");
    }
}

public class Blind
{
    public double _width;
    public double _height;
    public string _color;

    public double GetArea()
    {
        return _width * _height;
    }
}